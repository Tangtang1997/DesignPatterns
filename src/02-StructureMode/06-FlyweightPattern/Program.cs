// See https://aka.ms/new-console-template for more information
using _06_FlyweightPattern;

Console.WriteLine("Hello, World!");

TreeFactory treeFactory = new TreeFactory();

ITree tree1 = treeFactory.GetTree("Oak", "Green");
tree1.Display(10, 20);

ITree tree2 = treeFactory.GetTree("Pine", "Green");
tree2.Display(30, 40);

ITree tree3 = treeFactory.GetTree("Oak", "Green");
tree3.Display(50, 60);

// tree1 和 tree3 是同一个实例
Console.WriteLine(object.ReferenceEquals(tree1, tree3)); // 输出: True