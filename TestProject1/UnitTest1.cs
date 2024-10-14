using Xunit;
using Assert = Xunit.Assert;

public class CoffeeMachine
{
    // Método para seleccionar el tamaño del vaso
    public string SelectCupSize(int size)
    {
        if (size == 1)
            return "Small cup: 3 Oz";
        else if (size == 2)
            return "Medium cup: 5 Oz";
        else if (size == 3)
            return "Large cup: 7 Oz";
        else
            return "Invalid size";
    }

    // Método para seleccionar las cucharadas de azúcar
    public string SelectSugar(int spoonfuls)
    {
        if (spoonfuls >= 0 && spoonfuls <= 5)
            return $"{spoonfuls} spoonfuls of sugar selected.";
        else
            return "Invalid number of spoonfuls.";
    }
}


public class CoffeeMachineTests
{
    // Test para seleccionar el tamaño del vaso
    [Fact]
    public void SelectCupSize_ShouldReturnCorrectSize()
    {
        CoffeeMachine machine = new CoffeeMachine();

        // Prueba de selección del vaso pequeño
        Assert.Equal("Small cup: 3 Oz", machine.SelectCupSize(1));

        // Prueba de selección del vaso mediano
        Assert.Equal("Medium cup: 5 Oz", machine.SelectCupSize(2));

        // Prueba de selección del vaso grande
        Assert.Equal("Large cup: 7 Oz", machine.SelectCupSize(3));

        // Prueba de tamaño de vaso inválido
        Assert.Equal("Invalid size", machine.SelectCupSize(4));
    }

    // Test para seleccionar cucharadas de azúcar
    [Fact]
    public void SelectSugar_ShouldReturnCorrectSugarAmount()
    {
        CoffeeMachine machine = new CoffeeMachine();

        // Prueba de selección válida de cucharadas
        Assert.Equal("0 spoonfuls of sugar selected.", machine.SelectSugar(0));
        Assert.Equal("3 spoonfuls of sugar selected.", machine.SelectSugar(3));

        // Prueba de selección inválida de cucharadas
        Assert.Equal("Invalid number of spoonfuls.", machine.SelectSugar(6));
        Assert.Equal("Invalid number of spoonfuls.", machine.SelectSugar(-1));
    }
}