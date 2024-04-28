using FluentAssertions;
using SIE.Core.Crypto;

namespace SIE.Core.Test.Crypto
{
    public class EncryptionsShould
    {
        private Encriptions _encryptions;

        [SetUp]
        public void SetUp()
        {
            _encryptions = new Encriptions();
        }
    }
}
