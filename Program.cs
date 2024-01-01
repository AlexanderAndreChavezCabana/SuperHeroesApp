// See https://aka.ms/new-console-template for more information
using System.Text;
using SuperHeroesApp;
using SuperHeroesApp.Models;

var imprimirInfo = new ImprimirInfo();

Console.WriteLine("Hello, World!");

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;


var superFuerza = new SuperPoder();
superFuerza.Nombre = "Fuerza";
superFuerza.Descripcion = "Tener una fuerza anormal al humano";
superFuerza.Nivel = NivelPoder.NivelTres;

var superGarra = new SuperPoder();
superGarra.Nombre = "Garras";
superGarra.Descripcion = "Tener garras de acero";
superGarra.Nivel = NivelPoder.NivelDos;

var superRegeneración = new SuperPoder();
superRegeneración.Nombre = "Regeneración";
superRegeneración.Descripcion = "Regeneración super rapida";
superRegeneración.Nivel = NivelPoder.NivelDos;

var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "           Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
//superman.SuperPoderes = new[] { "Visión de rayos X", "Volar", "Super Fuerza", "Ojos rayos lazer" };


var superman2 = new SuperHeroe();
superman2.Id = 1;
superman2.Nombre = "Superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.Ciudad = "Metropolis";
superman2.PuedeVolar = true;

Console.WriteLine(superman2 == superman); // Tienen las mismas caracteristicas pero son diferentes objetos

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(superFuerza);
poderesSuperman.Add(poderVolar);



superman.SuperPoderes = poderesSuperman;



var batman = new SuperHeroe();
batman.Id = 2;
batman.Nombre = "Batman";
batman.IdentidadSecreta = "Bruno Diaz";
batman.Ciudad = "Gotica";
batman.PuedeVolar = false;
//batman.SuperPoderes = new[] { "Laser", "Fuerza Exponencial" };



Console.WriteLine(superman.UserSuperPoderes());

string resultSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);
string resultSalvarTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);

SuperHeroRecord superHeroRecord = new (1, "Superman", "Clark Kent");
SuperHeroRecord superHeroRecord2 = new(1, "Superman", "Clark Kent");

SuperPoderRecord superPoderRecord1 = new SuperPoderRecord("Volar", "Nadar");
SuperPoderRecord superPoderRecord2 = new SuperPoderRecord("Volar", "Nadar");
//superman.UserSuperPoderes();
Console.WriteLine("Super Poder Record igualdad");
Console.WriteLine(superPoderRecord1 == superPoderRecord2);
Console.WriteLine("Super Hero Record igualdad");
Console.WriteLine(superHeroRecord == superHeroRecord2); // Con record funciona

imprimirInfo.ImprimirSuperHero(superman);

// WOLVERINE ANTIHEROE
var wolverine = new AntiHeroe();
wolverine.Id = 3;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.Ciudad = "Cánada";
wolverine.PuedeVolar = false;
List<SuperPoder> superPoderes = new List<SuperPoder>();
superPoderes.Add(superGarra);
superPoderes.Add(superRegeneración);
wolverine.SuperPoderes = superPoderes;


Console.WriteLine(wolverine.UserSuperPoderes());

var garraCorte = wolverine.RealizarAccionDeAntiHeroe("Corte Garra");
Console.WriteLine(garraCorte);
Console.WriteLine(wolverine.UsarPoderes());


/// <summary>
/// // CLASSS AVE
/// </summary>
/// 


/// <summary>
/// Leon
/// </summary>

var jungla = new Habitat();
jungla.Id = 1;
jungla.Nombre = "jungla";
jungla.Descripcion = "Existen plantas, arboles, desertico y demás";
jungla.TipoHabitat = TipoHabitat.Terrestre;

var sabana = new Habitat();
sabana.Id = 2;
sabana.Nombre = "Sabana";
sabana.Descripcion = "Plantes y arena";

var pastizales = new Habitat();
pastizales.Id = 3;
pastizales.Nombre = "Pastizales";
pastizales.Descripcion = "Pastos seco";

var felino = new Familia();
felino.Id = 1;
felino.Nombre = "Felino";
felino.Descripcion = "Es del genero mamifero";

var leon = new Animal();
leon.Id = 1;
leon.Nombre = "         Leon           ";
leon.Tamanio = 1.8;

List<Familia> FamiliaFelino = new List<Familia>();
FamiliaFelino.Add(felino);

leon.Familia = FamiliaFelino;

List<Habitat> Habitats = new List<Habitat>();
Habitats.Add(jungla);
Habitats.Add(sabana);
Habitats.Add(pastizales);

leon.Habitat = Habitats;


AnimalRecord animalRecord = new AnimalRecord(1, "León", 1.2);
AnimalRecord animalRecord2 = new AnimalRecord(1, "León", 1.2);

Console.WriteLine("--------- Animal ---------");
Console.WriteLine("Animal Record igualdad");
Console.WriteLine(animalRecord == animalRecord2); // Con record funciona

//leon.AnimalHabitat();

Console.WriteLine(leon.AnimalHabitat());

//Console.WriteLine("LEÓN");
//Console.WriteLine($"ID: {leon.Id} - Nombre: {leon.Nombre} - Tamaño: {leon.Tamanio}");

//Console.WriteLine("Familia:");
//foreach (var familia in leon.Familia)
//{
//    Console.WriteLine($"ID: {familia.Id} - Nombre: {familia.Nombre} - Descripción: {familia.Descripcion}");
//}

//Console.WriteLine("Hábitat:");
//foreach (var habitat in leon.Habitat)
//{
//    Console.WriteLine($"ID: {habitat.Id} - Nombre: {habitat.Nombre} - Descripción: {habitat.Descripcion} - Tipo: {habitat.TipoHabitat}");
//}


/// <summary>
/// Pez
/// </summary>


var mar = new Habitat();
mar.Id = 2;
mar.Nombre = "Mar";
mar.Descripcion = "Algas, peces, plancton y demás";
mar.TipoHabitat = TipoHabitat.Maritimo;

//Console.WriteLine($"{ jungla.TipoHabitat } - { mar.TipoHabitat } ");

//////





public record SuperHeroRecord(int Id, string Nombre, string IdentidadSecreta);
public record SuperPoderRecord( string Nombre, string Descripcion );

///////////// Example
//// EXAMPLE ANIMAL

public record AnimalRecord( int Id, string Nombre, double Tamanio );
public record AnimalRecord2( int Id, string Nombre, double Tamanio );
