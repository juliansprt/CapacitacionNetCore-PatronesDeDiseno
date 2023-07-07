// See https://aka.ms/new-console-template for more information

using CapacitacionNetCore_PatronesDeDiseno.PatronesDiseno.Creacionales;
using CapacitacionNetCore_PatronesDeDiseno.PatronesDiseno.Estructurales;
using System.Reflection.Metadata.Ecma335;


#region Singleton
Console.Clear();
Console.WriteLine("-SINGLETON-");
Console.WriteLine("-----------");

//Singleton
Singleton singletonInstance = Singleton.Instance;
singletonInstance.LogMessage();
#endregion

#region Factory
Console.Clear();
Console.WriteLine("-FACTORY-");
Console.WriteLine("-----------");

string panType = "baguette";

PanFactory panFactory;

//switch (panType)
//{
//    case "baguette":
//        panFactory = new BaguetteFactory();
//        break;
//    default:
//        panFactory = new RolloFactory();
//        break;
//}

#region Switch
panFactory = panType switch
{
    "baguette" => new BaguetteFactory(),
    "rollo" => new RolloFactory(),
    _ => throw new ArgumentException("Tipo invalido")
};
#endregion

IPan pan = panFactory.CreatePan();
Console.WriteLine($"Nombre del pan: {pan.Name}");
#endregion

#region Decorator
Console.Clear();
Console.WriteLine("-DECORATOR-");
Console.WriteLine("-----------");

ICoffe coffe = new Espresso();
Console.WriteLine($"Cafe: {coffe.Description} | Precio: {coffe.Cost}");

coffe = new ConLeche(coffe);
Console.WriteLine($"Cafe: {coffe.Description} | Precio: {coffe.Cost}");

coffe = new ConCrema(coffe);
Console.WriteLine($"Cafe: {coffe.Description} | Precio: {coffe.Cost}");


#endregion

#region Composite
Console.Clear();
Console.WriteLine("-COMPOSITE-");
Console.WriteLine("-----------");
IEmployee daniel = new EmployeeDeveloper("Daniel Cardenas");
IEmployee dawverson = new EmployeeDeveloper("Dawverson Mejia");
IEmployee nelson = new EmployeeDeveloper("Nelson Rueda");
IEmployee eder = new EmployeeDeveloper("Eder de Jesus");
IEmployee enmanuel = new EmployeeTester("Enmanuel");

Team teamMisFacturas = new Team("Mis Facturas");
teamMisFacturas.AddMember(daniel);
teamMisFacturas.AddMember(dawverson);
teamMisFacturas.AddMember(nelson);
teamMisFacturas.AddMember(eder);
teamMisFacturas.AddMember(enmanuel);

teamMisFacturas.PerformDutties();

#endregion