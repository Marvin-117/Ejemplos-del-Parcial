Console.WriteLine("-------------------------Ejemplos--------------------------");

//ejemplo de Length 
string Cadena = "Marvin ";
int longitud = Cadena.Length;
Console.WriteLine("La longitud de la cadena es: " + longitud);

Console.WriteLine("-----------------------------------------------------------");

// ejemplo de ToUpper
string cadena = "a, b, c";
string cadenaenMayu = cadena.ToUpper();
Console.WriteLine("letras en Mayusculas:  " + cadenaenMayu);

Console.WriteLine("-----------------------------------------------------------");

//ejemplo de ToLower
string letrasM = "A, B, C";
string Letrasm = letrasM.ToLower();
Console.WriteLine("letras en Minusculas:  " + Letrasm);

Console.WriteLine("-----------------------------------------------------------");

//ejemplo de IndexOf

string st1 = "Marvin.";
int indice = st1.IndexOf("n");
Console.WriteLine("la ultima letra de mi nombre se encuentra en el indice: " + indice);

Console.WriteLine("-----------------------------------------------------------");

//ejemplo de LastIndexOf

string nombre = "Marvin Recinos Mazariegos.";
int last = nombre.LastIndexOf("a");
Console.WriteLine("la ultima a se encuentra en el indice: " + last);

Console.WriteLine("-----------------------------------------------------------");

//ejemplo de Substring

string nombreyapellido = "Marvin Ismael Recinos Mazariegos.";
string subcadena = nombreyapellido.Substring(14, 7);
Console.WriteLine("Primer apellido: " + subcadena);

Console.WriteLine("-----------------------------------------------------------");

//ejemplo en Replace

string oracionverdadera = "Marvin es muy Guapo";
string oracionfalsa = oracionverdadera.Replace("Guapo", "Feo");
Console.WriteLine("La nuva cadena falsa: " + oracionfalsa);

Console.WriteLine("-----------------------------------------------------------");

//ejemplo Trim

string direccion = "    Jalapa, Guatemala    ";
string sinespacios = direccion.Trim();
Console.WriteLine("La cadena sin espacios es: '" + sinespacios + "'");

Console.WriteLine("-----------------------------------------------------------");

//ejemplo startswith

string oracion = "Vamos a la playa";
bool comienzacon = oracion.StartsWith("la");
Console.WriteLine("¿La cadena comienza con 'la'? " + comienzacon ); //nos dira true si es correcto y False si es falso

//ejemplo de endswhith

bool terminacon = oracion.EndsWith("playa");
Console.WriteLine("¿La cadena termina con 'playa'? " + terminacon);

Console.WriteLine("-----------------------------------------------------------");
