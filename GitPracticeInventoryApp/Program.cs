Console.WriteLine("Hello, World!");

GitPracticeInventoryApp.Inventory inventory = new();
GitPracticeInventoryApp.Computers computer = new("Dell", 499.99);
GitPracticeInventoryApp.Televisions television = new("Samsung", 65, 799.99);

GitPracticeInventoryApp.Computers computer1 = new("HP", 349.99);
GitPracticeInventoryApp.Televisions television1 = new("Hisense", 55, 499.99);

inventory.AddComputerToListOfComputers(computer);
inventory.AddTelevisionToListOfTelevisions(television);
inventory.AddComputerToListOfComputers(computer1);
inventory.AddTelevisionToListOfTelevisions(television1);

inventory.GetListOfComputers();
inventory.GetListOfTelevisions();
