using System;

nameSpace Revisao 
{ 
  
  
  class Program 
{
   static void Main(string[] args) 
{
    Console.WriteLine ("Informe a opção desejada");
    Console.WriteLine ("1- Inserir novo aluno");
    Console.WriteLine ("2- Listar aluno");
    Console.WriteLine ("3- Calcular média geral");
    Console.WriteLine ("X- Sair");
    Console.WriteLine ();

    string opcaoUsuario = Console.ReadLine(); 
      
     while (opcaoUsuario.Toupper() != "X")
     {
     switch(opcaoUsuario)
     {
     case "1"
       //TODO: adcionar aluno
       break;
       case "2":
         //TODO: Listar alunos
         break;
       case "3":
         //TODO: calcular media geral
         break;
       default:
         throw new ArgumentOutOfRangeException();
     }  
     }
  }
}
}
 