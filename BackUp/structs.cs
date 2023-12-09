// var rectangle = new Rectangle(200, 3000);
// var immutablerectangle = new ImmutableRectangle(200, 300);
// public struct Rectangle
// {
//     public Rectangle(double width, double height)
//     {
//         Width = width;
//         Height = height;
//     }
//     public double Width { get; set; }
//     public double Height { get; set; }
// }
// public readonly struct ImmutableRectangle
// {
//     public ImmutableRectangle(double width, double height)
//     {
//         Width = width;
//         Height = height;
//     }
//     public double Width { get; init; }
//     public double Height { get; init; }
// }

//structs live in the stack it is better to create classes as we can change what we need into a struct.
// with readonly prop we cannot change the value of the instance