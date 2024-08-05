/// Crie um código que possui 2 vetores de 5 posições cada, onde é
///necessário o usuário preencher esses vetores, compara-los, e mostrar
///quais números são iguais entre os vetores e em quais posições eles
//estão.


int[] camaro = new int[5];
int[] monza = new int[5];

for (int i = 0;i < 5; i++)
{
    Console.WriteLine("digite um number");
    camaro[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("digite um number");
    monza[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
    for (int b = 0; b < 5; b++)
    {
        if (monza[i] == camaro[b])
        {
            Console.WriteLine(monza[i] + " é igual a " + camaro[b]);
        }

    }


}