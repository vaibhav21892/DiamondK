using DiamondK;

namespace TestDiamondK
{
    public class Tests
    {
        public class DiamondTest
        {
            [Test]
            public void Should_produce_a_single_charcter_when_diamond_is_smallest()
            {
                const string diamond = "A";

                Assert.That(Diamond.Create('A'), Is.EqualTo(diamond));
            }

            [Test]
            public void B_should_give_character_sequence()
            {
                Assert.That(Diamond.Create('B'), Does.Contain(" A\nB"));
            }

            [Test]
            public void B_should_repeat_characters()
            {
                Assert.That(Diamond.Create('B'), Does.Contain(" A\nB B\n"));
            }

            [Test]
            public void Should_print_diamond_when_call_with_B()
            {
                const string diamond = " A\n" +
                                       "B B\n" +
                                       " A";
                Assert.That(Diamond.Create('B'), Is.EqualTo(diamond));
            }

            [Test]
            public void Should_print_diamond_when_call_with_C()
            {
                const string diamond = "  A\n" +
                                       " B B\n" +
                                       "C   C\n" +
                                       " B B\n" +
                                       "  A";
                Assert.That(Diamond.Create('C'), Is.EqualTo(diamond));
            }

        }
    }
}