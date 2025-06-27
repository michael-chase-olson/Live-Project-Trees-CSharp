using binary_node1;
using nary_node1;

var root = new BinaryNode<string>{Value = "root"};
var nodeA = new BinaryNode<string>{Value = "A"};
var nodeB = new BinaryNode<string>{Value = "B"};
var nodeC = new BinaryNode<string>{Value = "C"};
var nodeD = new BinaryNode<string>{Value = "D"};
var nodeE = new BinaryNode<string>{Value = "E"};
var nodeF = new BinaryNode<string>{Value = "F"};

nodeE.AddLeft(nodeF);
nodeB.AddRight(nodeE);
nodeA.AddLeft(nodeC);
nodeA.AddRight(nodeD);

root.AddLeft(nodeA);
root.AddRight(nodeB);

Console.WriteLine("Binary Node Output");
Console.WriteLine(root.ToString());
/*Console.WriteLine(root);
Console.WriteLine(nodeA);
Console.WriteLine(nodeB);
Console.WriteLine(nodeC);
Console.WriteLine(nodeD);
Console.WriteLine(nodeE);
Console.WriteLine(nodeF);*/

var naryRoot = new NaryNode<string> {Value = "root"};

var naryNodeA = new NaryNode<string> {Value = "A"};
var naryNodeB = new NaryNode<string> {Value = "B"};
var naryNodeC = new NaryNode<string> {Value = "C"};
var naryNodeD = new NaryNode<string> {Value = "D"};
var naryNodeE = new NaryNode<string> {Value = "E"};
var naryNodeF = new NaryNode<string> {Value = "F"};
var naryNodeG = new NaryNode<string> {Value = "G"};
var naryNodeH = new NaryNode<string> {Value = "H"};
var naryNodeI = new NaryNode<string> {Value = "I"};

naryNodeF.AddChildren([naryNodeH, naryNodeI]);
naryNodeC.AddChild(naryNodeF);
naryNodeD.AddChild(naryNodeG);
naryNodeA.AddChildren([naryNodeD, naryNodeE]);
naryRoot.AddChildren([naryNodeA, naryNodeB, naryNodeC]);

Console.WriteLine("Nary Node Output");
Console.WriteLine(naryNodeA.ToString());
Console.WriteLine(naryRoot.ToString());
/*Console.WriteLine(naryRoot);
Console.WriteLine(naryNodeA);
Console.WriteLine(naryNodeB);
Console.WriteLine(naryNodeC);
Console.WriteLine(naryNodeD);
Console.WriteLine(naryNodeE);
Console.WriteLine(naryNodeF);
Console.WriteLine(naryNodeG);
Console.WriteLine(naryNodeH);
Console.WriteLine(naryNodeI);*/

