using DesafioPOO.Models;

Console.WriteLine("Smartphone marca: Iphone");
Iphone i1 = new Iphone("12345", "Modelo 01", "1111111111111", 32);

i1.Ligar();
i1.ReceberLigacao();
i1.DescricaoDoModelo();
i1.InstalarAplicativo("Shoppe");

Console.WriteLine("/==========================================");

Console.WriteLine("Smartphone marca: Nokia");
Iphone n1 = new Iphone("67890", "Modelo 02", "222222222222", 16);

n1.Ligar();
n1.ReceberLigacao();
n1.DescricaoDoModelo();
n1.InstalarAplicativo("Aliexpress");

Console.WriteLine("/==========================================");

Console.WriteLine("Smartphone marca: Samsung");
Samsung s1 = new Samsung("87645", "Modelo 03", "333333333333", 64);

s1.Ligar();
s1.ReceberLigacao();
s1.DescricaoDoModelo();
s1.InstalarAplicativo("Shien");