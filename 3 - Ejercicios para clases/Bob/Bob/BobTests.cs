namespace Bob
{
    public class BobTests
    {
        [Fact]
        public void Stating_something()
        {
            Assert.Equal("Whatever.", Ejercicio.Response("Tom-ay-to, tom-aaaah-to."));
        }
        public void Shouting()
        {
            Assert.Equal("Whoa, chill out!", Ejercicio.Response("WATCH OUT!"));
        }
        public void Shouting_gibberish()
        {
            Assert.Equal("Whoa, chill out!", Ejercicio.Response("FCECDFCAAB"));
        }
        public void Asking_a_question()
        {
            Assert.Equal("Sure.", Ejercicio.Response("Does this cryogenic chamber make me look fat?"));
        }
        public void Asking_a_numeric_question()
        {
            Assert.Equal("Sure.", Ejercicio.Response("You are, what, like 15?"));
        }
        public void Asking_gibberish()
        {
            Assert.Equal("Sure.", Ejercicio.Response("fffbbcbeab?"));
        }
        public void Talking_forcefully()
        {
            Assert.Equal("Whatever.", Ejercicio.Response("Hi there!"));
        }
        public void Using_acronyms_in_regular_speech()
        {
            Assert.Equal("Whatever.", Ejercicio.Response("It's OK if you don't want to go work for NASA."));
        }
        public void Forceful_question()
        {
            Assert.Equal("Calm down, I know what I'm doing!", Ejercicio.Response("WHAT'S GOING ON?"));
        }
        public void Shouting_numbers()
        {
            Assert.Equal("Whoa, chill out!", Ejercicio.Response("1, 2, 3 GO!"));
        }
        public void No_letters()
        {
            Assert.Equal("Whatever.", Ejercicio.Response("1, 2, 3"));
        }
        public void Question_with_no_letters()
        {
            Assert.Equal("Sure.", Ejercicio.Response("4?"));
        }
        public void Shouting_with_special_characters()
        {
            Assert.Equal("Whoa, chill out!", Ejercicio.Response("ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!"));
        }
        public void Shouting_with_no_exclamation_mark()
        {
            Assert.Equal("Whoa, chill out!", Ejercicio.Response("I HATE THE DENTIST"));
        }
        public void Statement_containing_question_mark()
        {
            Assert.Equal("Whatever.", Ejercicio.Response("Ending with ? means a question."));
        }
        public void Non_letters_with_question()
        {
            Assert.Equal("Sure.", Ejercicio.Response(":) ?"));
        }
        public void Prattling_on()
        {
            Assert.Equal("Sure.", Ejercicio.Response("Wait! Hang on. Are you going to be OK?"));
        }
        public void Silence()
        {
            Assert.Equal("Fine. Be that way!", Ejercicio.Response(""));
        }
        public void Prolonged_silence()
        {
            Assert.Equal("Fine. Be that way!", Ejercicio.Response("          "));
        }
        public void Alternate_silence()
        {
            Assert.Equal("Fine. Be that way!", Ejercicio.Response("\t\t\t\t\t\t\t\t\t\t"));
        }
        public void Multiple_line_question()
        {
            Assert.Equal("Whatever.", Ejercicio.Response("\nDoes this cryogenic chamber make me look fat?\nNo."));
        }
        public void Starting_with_whitespace()
        {
            Assert.Equal("Whatever.", Ejercicio.Response("         hmmmmmmm..."));
        }
        public void Ending_with_whitespace()
        {
            Assert.Equal("Sure.", Ejercicio.Response("Okay if like my  spacebar  quite a bit?   "));
        }
        public void Other_whitespace()
        {
            Assert.Equal("Fine. Be that way!", Ejercicio.Response("\n\r \t"));
        }
        public void Non_question_ending_with_whitespace()
        {
            Assert.Equal("Whatever.", Ejercicio.Response("This is a statement ending with whitespace      "));
        }
    }
}