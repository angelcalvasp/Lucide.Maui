using System.Runtime.CompilerServices;

namespace Lucide.Maui.Components;

public partial class LucideIcon : ContentView
{
    public static readonly BindableProperty IconProperty = 
        BindableProperty.Create(
            nameof(Icon),        
            typeof(string),
            typeof(LucideIcon),
            string.Empty,
            propertyChanged: OnIconChanged); 
    
    public static readonly BindableProperty ColorProperty = 
        BindableProperty.Create(
            nameof(Color),        
            typeof(Color),
            typeof(LucideIcon),
            default(Color),
            propertyChanged: OnColorChanged); 
    
    public static readonly BindableProperty SizeProperty = 
        BindableProperty.Create(
            nameof(Size),        
            typeof(double),
            typeof(LucideIcon),
            30d,
            propertyChanged: OnSizeChanged); 
    
    public string Icon
    {
        get => (string)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
    
    public Color Color
    {
        get => (Color)GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }
    
    public double Size
    {
        get => (double)GetValue(SizeProperty);
        set => SetValue(SizeProperty, value);
    }
    
    public LucideIcon()
    {
        InitializeComponent();
    }
    
    private static void OnIconChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (LucideIcon)bindable;
        control.ImageSource.Glyph = (string)newValue;
    }
    
    private static void OnColorChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (LucideIcon)bindable;
        control.ImageSource.Color = (Color)newValue;
    }
    
    private static void OnSizeChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (LucideIcon)bindable;
        control.FontImage.HeightRequest = (double)newValue;
        control.FontImage.WidthRequest = (double)newValue;
        control.ImageSource.Size = (double)newValue;
    }
}