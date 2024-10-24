// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Swapnil How do you do?");
 
  string path = @"~/.";
 
  using (StreamWriter writer = new StreamWriter(path, true))
  {
      writer.WriteLine($"{DateTime.Now.ToString()} -This is Running From Task.");
  }
 
  Console.ReadLine();
has context menu
