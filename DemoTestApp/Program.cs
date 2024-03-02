// See https://aka.ms/new-console-template for more information
using DemoTestApp;

//Singleton Pattern 

string className = Singleton.SingletonProp.GetClassName();

//Bridge Pattern 

Bridge bridge = new Bridge(new Tata());
var isValid = bridge.IsValidDriver(34);
bridge.GetCars();

//Adapter Pattern
Adaptee adaptee = new();
ITarget adapter = new Adapter(adaptee);
adapter.Request();


//Decorator Pattern
IComponent component = new Component();
string mainOperation = component.Operation();
IComponent decorateComponentA = new Decorator_A();
string decorateA_obj = decorateComponentA.Operation();


