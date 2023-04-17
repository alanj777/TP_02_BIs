class Boxeador {
    public string Nombre {get; set;}
    public string Pais {get;set;}
    public int Peso {get;set;}
    public int PotenciaGolpes {get; set;}
    public int VelocidadPiernas {get; set;}

    public Boxeador(string nombre, string pais, int peso, int potenciagolpes, int velocidadpiernas){
        
    }
    public double ObtenerSkill(){
     Random rnd = new Random();
     int randNum = rnd.Next(1, 10);
        double resultado = VelocidadPiernas * 0.6 + PotenciaGolpes * 0.8 + randNum;
       return resultado;
    }
}