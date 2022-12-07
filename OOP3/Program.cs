// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using OOP3;

PersonalCreditManager personalCreditManager= new PersonalCreditManager();

CarCrediManager carCrediManager = new CarCrediManager();

ICrediManager mortgageCrediManager = new MortgageCrediManager();

ILoggerService fileLoggerService = new FilebaseLoggerService();
ILoggerService dataLoggerService1 = new DatabaseLoggerService();


ApplicationManager ApplicationManager = new ApplicationManager();
ApplicationManager.makeApp(carCrediManager,dataLoggerService1);

List<ICrediManager> crediManagers = new List<ICrediManager>() { personalCreditManager , carCrediManager};

//ApplicationManager.crediInformation(crediManagers);