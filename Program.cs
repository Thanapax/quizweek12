class program{
    static void Main(string[] args){
        Console.WriteLine("-----------------------");
        Console.WriteLine("--------detail---------");
        Console.WriteLine("-----------------------");
        
        Console.Write("Pls input amount of item : ");
        int amount = int.Parse(Console.ReadLine());
        int x = 1;
        
        while(x >= 0 || x <= amount){
                Console.Write("Pls input name of item : ");
                string name = Console.ReadLine();
                Console.Write("Pls input type of item : ");
                string type = Console.ReadLine();
                Console.WriteLine("");
                x++;
        }
                Console.Write("Pls input Mode : ");
                string mode = Console.ReadLine();

                if(mode == "ShowAll"){
                    Console.WriteLine(name);
                    Console.WriteLine(type);    
                } else if(mode == type){
                    Console.WriteLine(name);
                } else {
                    Console.Write("End");
            
            }
            
    }
    
}