using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimesAndHighlyCompositeNumbers
{
    public partial class Form : System.Windows.Forms.Form
    {
        public List<uint> Primes { get; set; }
        public List<uint> Composites { get; set; }
        private BackgroundWorker MainWorker;
        public bool Paused { get; set; } = true;
        public DateTime Started { get; set; }
        public uint CurrentMaximum { get; set; }

        public string StartButtonContent { get => (Paused) ? "Start" : "Sleep"; }

        public Form()
        {
            InitializeComponent();

            MainWorker = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            MainWorker.DoWork += new DoWorkEventHandler(MainWorker_DoWork);
            MainWorker.ProgressChanged += new ProgressChangedEventHandler(MainWorker_ProgressChanged);
            MainWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(MainWorker_RunWorkerCompleted);
            Paused = true;

            Primes = new List<uint>();
            Composites = new List<uint>();
            
            PrimesGrid.Columns["primesColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            CompositesGrid.Columns["compositesColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void MainWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            Started = DateTime.Now;

            Invoke(new Action(() =>
            {
                CancelButton.Enabled = true;
                StatusLabel.Text = "Running";
                PrimesGrid.Rows.Clear();
                CompositesGrid.Rows.Clear();
            }));

            Primes.Clear();
            Composites.Clear();

            CurrentMaximum = 0;
            try
            {
                CurrentMaximum = (uint)e.Argument;
            }
            catch (Exception)
            {
                throw;
            }

            Debug.WriteLine(string.Format("Received user-set maximum {0}", CurrentMaximum));

            for (uint current = 1; current <= CurrentMaximum; current++)
            {
                Debug.WriteLine(string.Format("MainWorker: Reached number {0}", current));

                if (worker.CancellationPending)
                {
                    Debug.WriteLine("MainWorker: Whoa, someone has cut out budget! We are shutting down...");
                    Invoke(new Action(() =>
                    {
                        StatusLabel.Text = "Cancelled";
                    }));
                    e.Cancel = true;
                    return;
                }
                if (Paused)
                {
                    Debug.WriteLine("MainWorker: We're paused...");
                    Invoke(new Action(() =>
                    {
                        StatusLabel.Text = "Sleeping";
                    }));
                    while (Paused) Thread.Sleep(250);
                    Invoke(new Action(() =>
                    {
                        StatusLabel.Text = "Running";
                    }));
                    Debug.WriteLine("MainWorker: Unpaused again, continuing!");
                }

                if (current == 1)
                {
                    Debug.WriteLine("MainWorker: Is 1 prime? HaHa, very funny...");
                    PrimesAdd(current);
                    CompositesAdd(1, 1);
                }
                else
                {
                    if (IsPrime(current))
                    {
                        Debug.WriteLine("MainWorker: Number is a prime, storing it accordingly!");
                        PrimesAdd(current);
                        if (current == 2) CompositesAdd(2, 2);
                    }
                    else
                    {
                        List<uint> primeFactors = new List<uint>();
                        List<int> primeExponents = new List<int>();
                        uint tempCurrent = current;
                        int primeExponent = 0;

                        foreach (uint prime in Primes)
                        {
                            if (prime == 1)
                            {
                                Debug.WriteLine("MainWorker: And hey, there we have her one again...");
                                primeFactors.Add(1);
                                primeExponents.Add(1);
                            }
                            else
                            {
                                primeExponent = 0;
                                Debug.WriteLine(string.Format("MainWorker: Dividing by {0}", prime));
                                while (IsDivisible(tempCurrent, prime))
                                {
                                    tempCurrent = tempCurrent / prime;
                                    primeExponent++;
                                }

                                if (primeExponent == 0) break;

                                Debug.WriteLine(string.Format("MainWorker: Adding prime {0} and exponent {1} to lists of number {2}", prime, primeExponent, current));
                                primeFactors.Add(prime);
                                primeExponents.Add(primeExponent);
                            }

                            Invoke(new Action(() =>
                            {
                                TimeSpan elapsed = DateTime.Now.Subtract(Started);
                                string elapsedS = elapsed.ToString(@"\ d\ hh\:mm\:ss\ ");
                                ElapsedTimeLabel.Text = elapsedS;
                            }));
                        }
                        if (primeExponents[primeExponents.Count - 1] == 1 || (new uint[] { 4, 36 }).Contains(current))
                        {
                            int divisors = GetDivisorsCount(current);
                            if (divisors > GetDivisorsCount(Composites[Composites.Count - 1]))
                            {
                                Debug.WriteLine("MainWorker: Yaaaay, found another one composite!");
                                CompositesAdd(current, divisors);
                            }
                        }
                    }
                }

                try
                {
                    Debug.WriteLine("MainWorker: Reporting progress");
                    worker.ReportProgress((int)Math.Round(current / double.Parse(CurrentMaximum.ToString()) * 100), current);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void MainWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Debug.WriteLine("MainWorker_ProgressChanged: Setting progressbar value");
            MainWorkerProgressBar.Value = e.ProgressPercentage;
            PercentageLabel.Text = string.Format("{0} %", e.ProgressPercentage);
            CurrentNumberLabel.Text = string.Format(" Current number: {0} ", e.UserState);
            TimeSpan elapsed = DateTime.Now.Subtract(Started);
            TimeSpan remaining = TimeSpan.FromSeconds((elapsed.TotalSeconds / (uint)e.UserState) * (CurrentMaximum - (uint)e.UserState));
            RemainingLabel.Text = string.Format("Remaining: {0}", remaining.ToString(@"d\ hh\:mm\:ss"));
        }

        private void MainWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Debug.WriteLine("MainWorker_RunWorkerCompleted: MainWorker finished");
            if (e.Error != null) throw e.Error;
            Paused = true;
            CancelButton.Enabled = false;
            StartButton.Text = StartButtonContent;
            StatusLabel.Text = "Idle";
        }

        /// <summary>
        /// Calculates the number of existing divisors of the given number
        /// </summary>
        /// <param name="number">The number of which to calculate divisors</param>
        /// <returns>Count of possible divisors</returns>
        private int GetDivisorsCount(uint number)
        {
            int divisors = 1;
            List<int> primeExponents = new List<int>();

            foreach (uint prime in Primes)
            {
                if (prime != 1)
                {
                    int primeExponent = 0;
                    if (number == 48 || number == 60)
                    {
                        Debug.WriteLine("");
                    }
                    while (IsDivisible(number, prime) && number != 1) 
                    {
                        Debug.WriteLine(string.Format("GetDivisorsCount: Dividing {0} by {1}", number, prime));
                        number = number / prime;
                        primeExponent++;
                    }

                    divisors = divisors * (primeExponent + 1);
                }
            }

            return divisors;
        }

        /// <summary>
        /// Checks if a number is a prime by dividing by all already known primes
        /// </summary>
        /// <param name="number">The number to check for</param>
        /// <returns>Boolean whether or not number is prime</returns>
        private bool IsPrime(uint number)
        {
            foreach (uint prime in Primes)
            {
                if (IsDivisible(number, prime) && prime != 1) return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if number is divisible by the divider
        /// </summary>
        /// <param name="number">Number to be divided</param>
        /// <param name="divider">Number to divide with</param>
        /// <returns>Boolean whether the number can be divided by the divider</returns>
        private bool IsDivisible(uint number, uint divider)
        {
            //if (2 * divider > number) return false;
            Debug.WriteLine(string.Format("IsDivisible: Testing if {0} is divisible by {1}", number, divider));
            return number % divider == 0;
        }

        private bool ListIsWeaklyDecreasing(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1) 
                {
                    if (list[i] < list[i + 1]) return false;
                }
            }
            return true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!MainWorker.IsBusy) MainWorker.RunWorkerAsync((uint)MaximumValue.Value);
            Paused = !Paused;
            StartButton.Text = StartButtonContent;
        }

        private void PrimesAdd(uint prime)
        {
            Debug.WriteLine("PrimesAdd: Adding prime " + prime);
            Invoke(new Action(() =>
            {
                Primes.Add(prime);
                PrimesGrid.Rows.Add();
                PrimesGrid[0, PrimesGrid.Rows.Count - 1].Value = prime.ToString();
                PrimesGrid.FirstDisplayedScrollingRowIndex = PrimesGrid.RowCount - 1;
            }));
        }

        private void CompositesAdd(uint composite, int divisors)
        {
            Debug.WriteLine("CompositesAdd: Adding composite " + composite);
            Invoke(new Action(() =>
            {
                Composites.Add(composite);
                CompositesGrid.Rows.Add();
                CompositesGrid[0, CompositesGrid.Rows.Count - 1].Value = composite.ToString();
                CompositesGrid[1, CompositesGrid.Rows.Count - 1].Value = divisors.ToString();
                CompositesGrid.FirstDisplayedScrollingRowIndex = CompositesGrid.RowCount - 1;
            }));
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainWorker.CancelAsync();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://en.wikipedia.org/wiki/Highly_composite_numbers");
        }
    }

    public class Number
    {
        public uint Value { get; set; }

        public Number(uint value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
