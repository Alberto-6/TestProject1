using Xunit;
using Assert = Xunit.Assert;

public class CoffeeMachine
{
    // M�todo para seleccionar el tama�o del vaso
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

    // M�todo para seleccionar las cucharadas de az�car
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
    // Test para seleccionar el tama�o del vaso
    [Fact]
    public void SelectCupSize_ShouldReturnCorrectSize()
    {
        CoffeeMachine machine = new CoffeeMachine();

        // Prueba de selecci�n del vaso peque�o
        Assert.Equal("Small cup: 3 Oz", machine.SelectCupSize(1));

        // Prueba de selecci�n del vaso mediano
        Assert.Equal("Medium cup: 5 Oz", machine.SelectCupSize(2));

        // Prueba de selecci�n del vaso grande
        Assert.Equal("Large cup: 7 Oz", machine.SelectCupSize(3));

        // Prueba de tama�o de vaso inv�lido
        Assert.Equal("Invalid size", machine.SelectCupSize(4));
    }

    // Test para seleccionar cucharadas de az�car
    [Fact]
    public void SelectSugar_ShouldReturnCorrectSugarAmount()
    {
        CoffeeMachine machine = new CoffeeMachine();

        // Prueba de selecci�n v�lida de cucharadas
        Assert.Equal("0 spoonfuls of sugar selected.", machine.SelectSugar(0));
        Assert.Equal("3 spoonfuls of sugar selected.", machine.SelectSugar(3));

        // Prueba de selecci�n inv�lida de cucharadas
        Assert.Equal("Invalid number of spoonfuls.", machine.SelectSugar(6));
        Assert.Equal("Invalid number of spoonfuls.", machine.SelectSugar(-1));
    }
}