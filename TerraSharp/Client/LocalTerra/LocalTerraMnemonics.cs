namespace Terra.Microsoft.Client.Client.LocalTerra
{
    public static class LocalTerraMnemonics
    {
        public static LocalTerraData Validator { get; set; }
        public static LocalTerraData Test1 { get; set; }
        public static LocalTerraData Test2 { get; set; }
        public static LocalTerraData Test3 { get; set; }
        public static LocalTerraData Test4 { get; set; }
        public static LocalTerraData Test5 { get; set; }
        public static LocalTerraData Test6 { get; set; }
        public static LocalTerraData Test7 { get; set; }
        public static LocalTerraData Test8 { get; set; }
        public static LocalTerraData Test9 { get; set; }
        public static LocalTerraData Test10 { get; set; }

        static LocalTerraMnemonics()
        {
            Validator = new LocalTerraData()
            {
                Name = "validator",
                Address = "terra1dcegyrekltswvyy0xy69ydgxn9x8x32zdtapd8",
                Pubkey = "terrapub1addwnpepqflqjs2z2l52fku85zh65cxt8ctm4yn4nk5l9xyv80jq5hvszddpck20sd0",
                Mnemonic = "satisfy adjust timber high purchase tuition stool faith fine install that you unaware feed domain license impose boss human eager hat rent enjoy dawn",
            };

            Test1 = new LocalTerraData()
            {
                Name = "test1",
                Address = "terra1x46rqay4d3cssq8gxxvqz8xt6nwlz4td20k38v",
                Pubkey = "terrapub1addwnpepqgan82zjgdzqvxcjxext5g87pgdtxm2ys64lg5dm0n4az84zys09kyqtavw",
                Mnemonic = "notice oak worry limit wrap speak medal online prefer cluster roof addict wrist behave treat actual wasp year salad speed social layer crew genius"
            };
            Test2 = new LocalTerraData()
            {
                Name = "test2",
                Address = "terra17lmam6zguazs5q5u6z5mmx76uj63gldnse2pdp",
                Pubkey = "terrapub1addwnpepqdw9s9agjmw4fgntfuytd2x7qha94zlvv0edntkt7g3amz4wg75ewy9755w",
                Mnemonic = "quality vacuum heart guard buzz spike sight swarm shove special gym robust assume sudden deposit grid alcohol choice devote leader tilt noodle tide penalty"
            }; Test3 = new LocalTerraData()
            {
                Name = "test3",
                Address = "terra1757tkx08n0cqrw7p86ny9lnxsqeth0wgp0em95",
                Pubkey = "terrapub1addwnpepqgcxazmq6wgt2j4rdfumsfwla0zfk8e5sws3p3zg5dkm9007hmfysxas0u2",
                Mnemonic = "symbol force gallery make bulk round subway violin worry mixture penalty kingdom boring survey tool fringe patrol sausage hard admit remember broken alien absorb"
            }; Test4 = new LocalTerraData()
            {
                Name = "test4",
                Address = "terra199vw7724lzkwz6lf2hsx04lrxfkz09tg8dlp6r",
                Pubkey = "terrapub1addwnpepq0twklwp80hpeufr9f5k8a0lwr4kt5t7pzdl65x9ctka8uumpgyxjmq748f",
                Mnemonic = "bounce success option birth apple portion aunt rural episode solution hockey pencil lend session cause hedgehog slender journey system canvas decorate razor catch empty"
            }; Test5 = new LocalTerraData()
            {
                Name = "test5",
                Address = "terra18wlvftxzj6zt0xugy2lr9nxzu402690ltaf4ss",
                Pubkey = "terrapub1addwnpepq2dc0x07vtc5ds3fw08m392mw2wea4muglnd2demf84h0jclyf72xyzgrdq",
                Mnemonic = "second render cat sing soup reward cluster island bench diet lumber grocery repeat balcony perfect diesel stumble piano distance caught occur example ozone loyal"
            }; Test6 = new LocalTerraData()
            {
                Name = "test6",
                Address = "terra1e8ryd9ezefuucd4mje33zdms9m2s90m57878v9",
                Pubkey = "terrapub1addwnpepqgf9e8p3sjj7w8tc5vhz685satqz8fxlq05xu52ykgemjm3tl2l37xj0qdx",
                Mnemonic = "spatial forest elevator battle also spoon fun skirt flight initial nasty transfer glory palm drama gossip remove fan joke shove label dune debate quick"
            }; Test7 = new LocalTerraData()
            {
                Name = "test7",
                Address = "terra17tv2hvwpg0ukqgd2y5ct2w54fyan7z0zxrm2f9",
                Pubkey = "terrapub1addwnpepqd2a3l2sfzl75ym7ej5xg0h07y9f393vnj4ud8jjs8swnkf90qh0y4zujvh",
                Mnemonic = "noble width taxi input there patrol clown public spell aunt wish punch moment will misery eight excess arena pen turtle minimum grain vague inmate"
            }; Test8 = new LocalTerraData()
            {
                Name = "test8",
                Address = "terra1lkccuqgj6sjwjn8gsa9xlklqv4pmrqg9dx2fxc",
                Pubkey = "terrapub1addwnpepqg0emd34d0k4xmdqfps8rme7p5c4lhpg0k5egfxumytfklw04mesc2kpzlg",
                Mnemonic = "cream sport mango believe inhale text fish rely elegant below earth april wall rug ritual blossom cherry detail length blind digital proof identify ride"
            }; Test9 = new LocalTerraData()
            {
                Name = "test9",
                Address = "terra1333veey879eeqcff8j3gfcgwt8cfrg9mq20v6f",
                Pubkey = "terrapub1addwnpepq0a9ks8fnqjn0cllypeggdu50eeww68h7at6jwzfkvq60pgnare2y73jcl8",
                Mnemonic = "index light average senior silent limit usual local involve delay update rack cause inmate wall render magnet common feature laundry exact casual resource hundred"
            }; Test10 = new LocalTerraData()
            {
                Name = "test10",
                Address = "terra1fmcjjt6yc9wqup2r06urnrd928jhrde6gcld6n",
                Pubkey = "terrapub1addwnpepqw5l3ax2du5lxhquwquwv5dufvp8kmk4aewz7kg8cujdv55mh936j36ex2c",
                Mnemonic = "prefer forget visit mistake mixture feel eyebrow autumn shop pair address airport diesel street pass vague innocent poem method awful require hurry unhappy shoulder"
            };
        }
    }

    public class LocalTerraData
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Pubkey { get; set; }
        public string Mnemonic { get; set; }
    }
}
