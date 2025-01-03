// See https://aka.ms/new-console-template for more information
using _08_StatePattern;

Console.WriteLine("Hello, World!");

LightSwitch lightSwitch = new LightSwitch();

lightSwitch.PressSwitch(); // 输出: Light is OFF. Turning it ON now.
lightSwitch.PressSwitch(); // 输出: Light is already ON. Turning it OFF now.
lightSwitch.PressSwitch(); // 输出: Light is OFF. Turning it ON now.