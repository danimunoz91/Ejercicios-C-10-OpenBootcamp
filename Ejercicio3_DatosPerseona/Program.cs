Console.WriteLine("Digite nombre:"); 
string nombre = Console.ReadLine();

Console.WriteLine("Digite apellido:");
string apellido = Console.ReadLine();

Console.WriteLine("Digite edad:");
int edad = Convert.ToInt32(Console.ReadLine());

string mensaje = nombre + ","+apellido + "," + edad + " sabe programar";

Console.WriteLine(mensaje);