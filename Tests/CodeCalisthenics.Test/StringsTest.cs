using CodeCalisthenics.Operations;
using Xunit;

namespace CodeCalisthenics.Test
{
    public class StringsTest
    {
        public Strings Sut { get; set; }

        public StringsTest()
        {
            Sut = new Strings();
        }

        [Theory]
        [InlineData("Hacker", "Hce")]
        [InlineData("Rank", "Rn")]
        [InlineData("ovyvzvptyvpvpxyztlrztsrztztqvrxtxuxq", "oyzpyppytrtrttvxxx")]
        [InlineData("holtm", "hlm")]
        [InlineData("uvzxrumuztyqyvpnji", "uzrmzyypj")]
        [InlineData("tmruzxzuwoskqysxztuvosuyrswrnmtxvzsrqwytzrxpltrwusxupw", "trzzwsqszuourwntvsqyzxlruxp")]
        [InlineData("wxstwxuzuyuvyzrsxysxyuvyqxuxyskqwsyqumqrvopvowqumnvrxpwqpwsrnvrztxrxpvuxunvyzvupvupowvyzvzuzwvsrwv", "wswuuuyrxsyvquykwyuqvpoqmvxwpsnrtrpuuvzuvpwyvuwsw")]
        [InlineData("yrzxrxskrtlpwpmtpxvowrxrpxq", "yzrsrlwmpvwxpq")]
        [InlineData("pryumtuntmovpwvowslj", "pymutopvwl")]
        [InlineData("nosklrxrtyuxtmnurzsryuxtywqwqpxts", "nslxtutnrsyxyqqxs")]
        [InlineData("fmpszyvqwxrtvpuwqszvyvotmsxsxuvzyvpwzrpmuxqwtswvytytzsnuxuyrpvtysqoutzurqxury", "fpzvwrvuqzyomxxvypzpuqtwyyznxyptsotuquy")]
        [InlineData("jkmsxzwrxzy", "jmxwxy")]
        public void ShouldPrintEvenLetters(string word, string expectedString)
        {
            var result = Sut.GetEvenAndOddLetters(word).Item1;

            Assert.Equal(expectedString, result);
        }

        [Theory]
        [InlineData("Hacker", "akr")]
        [InlineData("Rank", "ak")]
        [InlineData("ovyvzvptyvpvpxyztlrztsrztztqvrxtxuxq", "vvvtvvxzlzszzqrtuq")]
        [InlineData("holtm", "ot")]
        [InlineData("uvzxrumuztyqyvpnji", "vxuutqvni")]
        [InlineData("tmruzxzuwoskqysxztuvosuyrswrnmtxvzsrqwytzrxpltrwusxupw", "muxuokyxtvsysrmxzrwtrptwsuw")]
        [InlineData("wxstwxuzuyuvyzrsxysxyuvyqxuxyskqwsyqumqrvopvowqumnvrxpwqpwsrnvrztxrxpvuxunvyzvupvupowvyzvzuzwvsrwv", "xtxzyvzsyxuyxxsqsqmrovwunrpqwrvzxxvxnyvpuovzzzvrv")]
        [InlineData("yrzxrxskrtlpwpmtpxvowrxrpxq", "rxxktpptxorrx")]
        [InlineData("pryumtuntmovpwvowslj", "rutnmvwosj")]
        [InlineData("nosklrxrtyuxtmnurzsryuxtywqwqpxts", "okrryxmuzrutwwpt")]
        [InlineData("fmpszyvqwxrtvpuwqszvyvotmsxsxuvzyvpwzrpmuxqwtswvytytzsnuxuyrpvtysqoutzurqxury", "msyqxtpwsvvtssuzvwrmxwsvttsuurvyquzrxr")]
        [InlineData("jkmsxzwrxzy", "kszrz")]
        public void ShouldPrintOddLetters(string word, string expectedString)
        {
            var result = Sut.GetEvenAndOddLetters(word).Item2;

            Assert.Equal(expectedString, result);
        }

        [Theory]
        [InlineData("Hacker", "Rank", "Hce akr\n" + "Rn ak")]
        public void ShouldPrintEvenAndOddLetters(string one, string two, string expectedResult)
        {
            var actualResult = Sut.OddEvenStringGenerator(one, two);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("wxstwxuzuyuvyzrsxysxyuvyqxuxyskqwsyqumqrvopvowqumnvrxpwqpwsrnvrztxrxpvuxunvyzvupvupowvyzvzuzwvsrwv", "wswuuuyrxsyvquykwyuqvpoqmvxwpsnrtrpuuvzuvpwyvuwsw xtxzyvzsyxuyxxsqsqmrovwunrpqwrvzxxvxnyvpuovzzzvrv")]
        public void ShouldPrintEvenAndOdd(string word, string expectedResult1)
        {
            string[] args =
            {
                expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1,expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1,
                expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1,expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1, expectedResult1
            };
            var expectedResult = string.Join("\n", args);

            var actualResult = Sut.OddEvenStringGenerator(word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word, word);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
