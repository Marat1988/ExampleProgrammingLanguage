import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.function.Executable;

import static org.junit.jupiter.api.Assertions.*;

public class CalculatorTest {

    private Calculator calculator;

    @BeforeEach
    public void setUp() {
        calculator = new Calculator();
    }

    @Test
    public void whenAddTenToFiveThenResultFifteen() {
        double expected = 15;
        double result = calculator.add(10, 5);
        assertEquals(expected, result, 0.001);
    }

    @Test
    public void when5AddTo10AsStringThenResult15() {
        double expected = 15;
        double result = calculator.add("10", "5");
        assertEquals(expected, result, 0.001);
    }

    /*https://junit.org/junit5/docs/current/user-guide/#writing-tests-assertions*/
    @Test
    public void whenInputIncorrectValueThenThrowException() {
        Exception exception = assertThrows(NumberFormatException.class, () -> calculator.add("www", "5"));
        assertEquals("For input string: \"www\"", exception.getMessage());
    }

    @Test
    public void add() {
        double expected2 = 150;
        double result2 = calculator.add(100, 50);
        assertEquals(expected2, result2, 0.001);
    }

    @Test
    public void divide() {
        double expected = 10;
        double result = calculator.divide(100, 10);
        assertEquals(expected, result, 0.001);
        double expected2 = 3;
        double result2 = calculator.divide(9, 3);
        assertEquals(expected2, result2, 0.001);
    }

    @Test
    public void multiple() {
        double expected = 50;
        double result = calculator.multiple(5, 10);
        assertEquals(expected, result, 0.001);
        double expected2 = 9;
        double result2 = calculator.multiple(3, 3);
        assertEquals(expected2, result2, 0.001);
    }

    @Test
    public void square() {
        double expected = 100;
        double result = calculator.square(10);
        assertEquals(expected, result, 0.001);
        double expected2 = 36;
        double result2 = calculator.square(6);
        assertEquals(expected2, result2, 0.001);
    }

    @AfterEach
    public void close() {
        calculator = null;
    }
}