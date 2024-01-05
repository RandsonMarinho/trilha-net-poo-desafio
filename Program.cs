using DesafioPOO.Models;

Iphone i = new Iphone("123", "Iphone", "174950056345530", 60);
i.InstalarAplicativo("Terraria");

Nokia n = new Nokia("235", "Nokia", "345653637898787", 40);
n.InstalarAplicativo("Minecraft");


i.Ligar();
n.ReceberLigacao();