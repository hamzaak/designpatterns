using System;

namespace chainofresponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup the chain of responsibility
            var mustafa = new Manager();
            var emre = new AssistantManager();
            var hamza = new Clerk();

            emre.Successor = mustafa;
            hamza.Successor = emre;

            // Make loan requests
            var loan = new Loan { Number = 2034, Amount = 24000.00, Purpose = "Laptop Loan" };
            hamza.ProcessRequest(loan);

            loan = new Loan { Number = 2035, Amount = 42000.00, Purpose = "Bike Loan" };
            hamza.ProcessRequest(loan);

            loan = new Loan { Number = 2036, Amount = 72000.00, Purpose = "Car Loan" };
            hamza.ProcessRequest(loan);

            loan = new Loan { Number = 2037, Amount = 156200.00, Purpose = "House Loan" };
            hamza.ProcessRequest(loan);

            Console.ReadKey();
        }
    }


    class Loan
    {
        public double Amount { get; set; }
        public string Purpose { get; set; }
        public int Number { get; set; }
    }

    // Loan event argument holds Loan info
    class LoanEventArgs : EventArgs
    {
        internal Loan Loan { get; set; }
    }

    abstract class Approver
    {
        public Approver Successor { get; set; }
        public EventHandler<LoanEventArgs> Loan;
        public abstract void LoanHandler(object sender, LoanEventArgs e);

        public Approver()
        {
            Loan += LoanHandler;
        }
        public void ProcessRequest(Loan loan)
        {
            OnLoan(new LoanEventArgs { Loan = loan });
        }
        public virtual void OnLoan(LoanEventArgs e)
        {
            if (Loan != null)
            {
                Loan(this, e);
            }
        }
    }

    class Clerk : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 25000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request# {e.Loan.Number}");
            }
            else if (Successor != null)
            {
                Successor.LoanHandler(this, e);
            }
        }
    }

    class AssistantManager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 45000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request# {e.Loan.Number}");
            }
            else if (Successor != null)
            {
                Successor.LoanHandler(this, e);
            }
        }
    }

    class Manager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 100000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request# {e.Loan.Number}");
            }
            else if (Successor != null)
            {
                Successor.LoanHandler(this, e);
            }
            else
            {
                Console.WriteLine($"Request# {e.Loan.Number} requires an executive meeting!");
            }
        }
    }
}
