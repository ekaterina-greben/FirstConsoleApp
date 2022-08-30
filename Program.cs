// See https://aka.ms/new-console-template for more information

using FirstConsoleApp;

Console.WriteLine("Hello, World! Version 0.0.3");

static int sumAllFees(int incomeTaxSum, int socialInsuranceSum, int additionalMedicalInsuranceSum, int pensionFundSum, int charityFeesSum)
{
    return incomeTaxSum + socialInsuranceSum + additionalMedicalInsuranceSum + pensionFundSum + charityFeesSum;
}

Console.WriteLine("Enter employee's first name and last name: ");

// FIXME: Check value for empty string

String? employeeFNLN;

employeeFNLN = Console.ReadLine();

// TODO: Check empty first name and empty last name

string[] fnlnArr = employeeFNLN!.Split(" ");

Console.WriteLine("Enter income: ");
int startIncome = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter experience years: ");
int experienceYears = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of passed exams: ");
int numberOfPassedExams = Convert.ToInt32(Console.ReadLine());

Employee epl = new Employee(fnlnArr[0], fnlnArr[1], 7, 10); 

int income = epl.getIncomeSum(startIncome);

int incomeTax = 5;
int socialInsurance = 5;

socialInsurance = getSocialInsurance(income);

int additionalMedicalInsurance = 10;
int pensionFund = 5;
int charityFees = 1;

int incomeTaxSum = income / 100 * incomeTax;
int socialInsuranceSum = income / 100 * socialInsurance;
int additionalMedicalInsuranceSum = income / 100 * additionalMedicalInsurance;
int pensionFundSum = income / 100 * pensionFund;
int charityFeesSum = income / 100 * charityFees;

int totalFees = sumAllFees(incomeTaxSum, socialInsuranceSum, additionalMedicalInsuranceSum, pensionFundSum, charityFeesSum);

int salaryNetto = income - totalFees;

printInfo(epl.firstName, epl.lastName, incomeTaxSum, socialInsuranceSum, additionalMedicalInsuranceSum, pensionFundSum, charityFeesSum, totalFees, salaryNetto);

static int getSocialInsurance(int income)
{
    int socialInsurance;
    if (income > 2000)
    {
        socialInsurance = 5;
    }
    else if (income >= 2000 && income < 5000)
    {
        socialInsurance = 10;
    }
    else
    {
        socialInsurance = 35;
    }

    return socialInsurance;
}

static void printInfo(string? employeeFN, string? employeeLN, int incomeTaxSum, int socialInsuranceSum, int additionalMedicalInsuranceSum, int pensionFundSum, int charityFeesSum, int totalFees, int salaryNetto)
{
    System.Console.WriteLine("Income Tax: " + incomeTaxSum);
    System.Console.WriteLine("Social Insurance: " + socialInsuranceSum);
    System.Console.WriteLine("Additional Medical Insurance: " + additionalMedicalInsuranceSum);
    System.Console.WriteLine("Pension Fund: " + pensionFundSum);
    System.Console.WriteLine("Charity Fees: " + charityFeesSum);
    System.Console.WriteLine("Total fees: " + totalFees);
    System.Console.WriteLine("Your netto salary for " + employeeFN + " " + employeeLN + " " +" is " + salaryNetto);
}