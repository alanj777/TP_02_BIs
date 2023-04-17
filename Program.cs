namespace TP02_Bis_Jolodovsky;
class Program
{
    static void Main(string[] args)
    {
        string nombre, pais;
        int peso, potenciagolpes, velocidadpiernas;
        int opcion = 0;
        while (opcion != 4){
        opcion = IngresarEntero("Ingresá una opción: \n 1- Cargar Datos Boxeador 1 \n 2- Cargar Datos Boxeador 2 \n 3- Pelear! \n 4- Salir");
        switch (opcion)
     { case 1:
     nombre = IngresarString("Ingresá el nombre del boxeador 1");
     pais = IngresarString("Ingresá el país del boxeador 1");
     peso = IngresarEntero("Ingresá el peso del boxeador 1");
     potenciagolpes = IngresarEntero("Ingresá la potencia del boxeador 1");
     velocidadpiernas = IngresarEntero("Ingresá la velocidad de las piernas del boxeador 1");
       Boxeador boxeador1 = new Boxeador(nombre,pais, peso, potenciagolpes, velocidadpiernas);
       break;
       case 2 :
       nombre = IngresarString("Ingresá el nombre del boxeador 2");
     pais = IngresarString("Ingresá el país del boxeador 2");
     peso = IngresarEntero("Ingresá el peso del boxeador 2");
     potenciagolpes = IngresarEntero("Ingresá la potencia del boxeador 2");
     velocidadpiernas = IngresarEntero("Ingresá la velocidad de las piernas del boxeador 2");
       Boxeador boxeador2 = new Boxeador(nombre,pais, peso, potenciagolpes, velocidadpiernas);
       break;
     
     case 3:
     double valorSkill1 = boxeador1.ObtenerSkill();
     double valorSkill2 = boxeador2.ObtenerSkill();
     if (valorSkill1 == valorSkill2){
       Console.WriteLine("Empataron entre el luchador " + boxeador1.Nombre + " y el luchador " + boxeador2.Nombre);
     }
     else if (valorSkill1 > valorSkill2){
       if (valorSkill1 >= 30){
          Console.WriteLine("Ganó el boxeador " + boxeador1.Nombre + " por K.O.");
       }
       else if (valorSkill1>=10){
        Console.WriteLine("Ganó el boxeador " + boxeador1.Nombre + " por puntos en fallo unánime");
       }
       else{
        Console.WriteLine("Ganó el boxeador " + boxeador1.Nombre + " por puntos en fallo dividido");
       }
     }
     else{
          if (valorSkill2 >= 30){
          Console.WriteLine("Ganó el boxeador " + boxeador2.Nombre + " por K.O.");
       }
       else if (valorSkill2>=10){
        Console.WriteLine("Ganó el boxeador " + boxeador2.Nombre + " por puntos en fallo unánime");
       }
       else {
        Console.WriteLine("Ganó el boxeador " + boxeador2.Nombre + " por puntos en fallo dividido");
       }
     }
     break;
     case 4:
     break;
     default:
     Console.WriteLine("Error, número no disponible en el rango indicado");
     break;
     }
    }
   }
       static int IngresarEntero(string mensaje){
      int num;
      Console.WriteLine(mensaje);
      num = int.Parse(Console.ReadLine());
      return num;
    }
    static string IngresarString(string mensaje){
     string Respuesta;
     Console.WriteLine(mensaje);
     Respuesta = Console.ReadLine();
     return Respuesta;
    }
   }

