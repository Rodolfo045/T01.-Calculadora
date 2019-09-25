using System;


public class Calculadora{
    

    public void Calcular(){
        //Varivables globales
        double a;
        double b;
        int a1 = 0;

        
        Console.WriteLine("Bienvenido "+"\n" + "Ingrese dos datos por favor");
        Console.WriteLine("Dato 1:");
        //El readline lee una linea de texto asi que debo convertirlo al tipo de dato que necesito para realizar
        //las operaciones
       a= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dato 2:");
        //El Readline lee una linea de texto asi que debo convertirlo al tipo de dato que necesito
        //para las operaciones
        b =Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Ingrese la opcion que desee por favor"+"\n"+"1-Sumar"+"\n"+"2-Restar"+"\n"+
        "3-Multiplicar"+"\n"+"4-Dividir");
        //El metodo Readline lee un string asi que debo convertir a entero para poder usarlo en el Switch
        
        a1 = Convert.ToInt32(Console.ReadLine());
        //Instanció el objeto Op para poder llamar a los métodos
        Operacion op = new Operacion();
        double Resultado;

        switch (a1)
        {//Menu para elegir las opciones
            case 1:
            Resultado = op.Sumar(a,b);
            Console.WriteLine("El resultado es :"+Resultado.ToString());
            break;

            case 2:
           Resultado =  op.Restar(a,b);
           Console.WriteLine("El resultado es :"+Resultado.ToString());
            break;

            case 3:
           Resultado =  op.Multiplicar(a,b);
           Console.WriteLine("El resultado es :"+Resultado.ToString());
            break;

            case 4:
            Resultado = op.Dividir(a,b);
            Console.WriteLine("El resultado es :"+Resultado.ToString());
            break;

            
            
            default:
            break;
        }
        

        


    }










}



public class Operacion{

    public double  Multiplicar(double a, double b){//Multiplica e imprime el resultado
        double r;
        r = a*b;
        return r;
    }

    public double Sumar(double c, double d){//Suma e imprime el resultado
        double p;
        p = c+d;
        return p;
    } 
    public double Dividir(double e, double f){ //divide e imprime el resultadp
        double s;
        s= e/f;
        return s;
    }
     //Resta e imprime el resultado
    public double Restar(double g, double h){
        double f;
        f=g-h;
        return f;

    }


    

}
namespace asdfghjkl
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Calculadora d = new Calculadora();//Instanció el objeto Calculadora para poder llamar a los métodos
            d.Calcular();//Llamada al método calcular
            


    }
}}