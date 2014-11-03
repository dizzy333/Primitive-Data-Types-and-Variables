using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Bank_Account_Data
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName, middleName, lastName, bankName, IBAN;
            decimal balance;
            ulong creditCard, debitCard, masterCard;

            firstName = "Teodor";
            middleName = "Ivanov";
            lastName = "Atanasov";
            bankName = "D-bank";
            IBAN = "BG45JTFR18549762584535";
            IBAN = "BG20TTBB94003526341239";
            balance = 257468.112M;
            creditCard = 25487652846512958;
            debitCard = 45985632785126859;
            masterCard = 45875632159845635;

            Console.WriteLine("nFirst Name: {0}\nMiddle Name: {1}\nLast Name: {2}\nBank Name: {3}\nIBAN: {4}\nBalance: {5}\nCreditCard: {6}\nDebit Card: {7}\nMaster Card: {8}", firstName, middleName, lastName, bankName, IBAN, balance, creditCard, debitCard, masterCard);
            

        }
    }
}
