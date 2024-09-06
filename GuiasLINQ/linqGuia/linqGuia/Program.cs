// See https://aka.ms/new-console-template for more information
using linqGuia;

Console.WriteLine("Hello, World!");

//LinQ

#region ListaModelos

List<Casa> listaCasa = new List<Casa>();
List<Habitante> listaHabitante = new List<Habitante>();

#endregion

#region Casa

// Clase anónima - No se puede escribir sobre ella, son de solo lectura.
listaCasa.Add(new Casa
{
    IdCasa = 1,
    Direccion = "3 avn Chalatenango",
    Ciudad = "Chalatenango",
    numeroHabitaciones = 20
});

listaCasa.Add(new Casa
{
    IdCasa = 2,
    Direccion = "4 av",
    Ciudad = "San Salvador",
    numeroHabitaciones = 9
});

listaCasa.Add(new Casa
{
    IdCasa = 3,
    Direccion = "6 avn",
    Ciudad = "San Miguel",
    numeroHabitaciones = 5
});

#endregion

#region Habitante

listaHabitante.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Elena",
    Edad = 25,
    IdCasa = 1
});

listaHabitante.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Carlos",
    Edad = 20,
    IdCasa = 2
});

listaHabitante.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Alfredo",
    Edad = 30,
    IdCasa = 3
});

listaHabitante.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Luis",
    Edad = 50,
    IdCasa = 2
});

listaHabitante.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Sonia",
    Edad = 18,
    IdCasa = 2
});

listaHabitante.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Elmer",
    Edad = 36,
    IdCasa = 2
});

listaHabitante.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Miguel",
    Edad = 45,
    IdCasa = 2
});

listaHabitante.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Olga",
    Edad = 15,
    IdCasa = 2
});

#endregion

#region SentenciaLinQ

// Nos permite tener un elemento sobre el que iteraremos 
IEnumerable<Habitante> listaEdad = from objTemporal in listaHabitante
                                   where objTemporal.Edad > 40 
                                   select objTemporal;

// foreach no afecta al elemento recorrido
foreach(var iteracion in listaEdad)
{
    Console.WriteLine(iteracion.datosHabitante());
}

// JOIN
IEnumerable<Habitante> listaCasa = from objTemporalHabitante in listaHabitante
                                   join objTemporalCasa in listaCasa
                                   on objTemporalHabitante.IdHabitante equals objTemporalCasa.IdCasa
                                   where objTemporalCasa.Ciudad = "Chalatenango"
                                   select objTemporalHabitante;


#endregion

#region 



#endregion