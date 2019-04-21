using System;
using System.Collections.Generic;

namespace JsonSerializer_NullReferenceException_Repro
{
    public sealed class RootObject
    {
        public string A { get; set; }
        public long B { get; set; }
        public bool C { get; set; }
        public ModelA D { get; set; } = new ModelA();
        public ModelE E { get; set; } = new ModelE();
        public ModelF F { get; set; }
        public ModelG G { get; set; }
        public ModelH H { get; set; } = new ModelH();
        public ModelI I { get; set; } = new ModelI();
        public string J { get; set; }
        public bool K { get; set; }
        public bool L { get; set; }
        public bool M { get; set; }
        public ModelN N { get; set; }
        public ModelO O { get; set; } = new ModelO();
        public ModelP P { get; set; }
    }

    public class ModelA
    {
        public string A { get; set; }
        public ModelZ B { get; set; }
        public DateTimeOffset C { get; set; }
        public DateTimeOffset D { get; set; }
        public DateTimeOffset E { get; set; }
        public bool F { get; set; }
    }

    public class ModelB
    {
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public double? D { get; set; }
        public double? E { get; set; }
    }

    public sealed class ModelC
    {
        public string A { get; set; }
        public string B { get; set; }
    }

    public sealed class ModelD
    {
        public long A { get; set; }
        public int B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
    }

    public class ModelE
    {
        public int A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public ModelB D { get; set; }
        public string E { get; set; }
        public string F { get; set; }
        public string G { get; set; }
        public string H { get; set; }
        public bool I { get; set; }
        public bool J { get; set; }
        public ModelX K { get; set; }
        public bool L { get; set; }
        public bool M { get; set; }
        public bool N { get; set; }
        public bool O { get; set; }
        public DateTime? P { get; set; }
        public DateTime? Q { get; set; }
        public bool R { get; set; }
        public bool S { get; set; }
        public IList<ModelC> T { get; set; }
        public IList<ModelD> U { get; set; }
    }

    public class ModelF
    {
        public string A { get; set; }
        public IList<ModelJ> B { get; set; } = new List<ModelJ>();
        public decimal C { get; set; }
        public decimal D { get; set; }
        public DateTimeOffset? E { get; set; }
        public string F { get; set; }
    }

    public sealed class ModelG
    {
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
        public string F { get; set; }
        public string G { get; set; }
        public string H { get; set; }
        public string I { get; set; }
        public string J { get; set; }
        public ModelK K { get; set; }
    }

    public sealed class ModelH
    {
        public string A { get; set; }
        public int B { get; set; }
        public IList<ModelL> C { get; set; }
        public IList<ModelU> D { get; set; }
        public decimal E { get; set; }
        public decimal F { get; set; }
        public decimal G { get; set; }
        public decimal H { get; set; }
        public decimal I { get; set; }
        public decimal J { get; set; }
        public IList<ModelV> K { get; set; }
        public ModelW L { get; set; }
    }

    public class ModelI
    {
        public string A { get; set; }
        public string B { get; set; }
    }

    public sealed class ModelJ
    {
        public ModelY A { get; set; }
        public decimal B { get; set; }
        public string C { get; set; }
        public decimal D { get; set; }
        public string E { get; set; }
        public string F { get; set; }
        public string G { get; set; }
        public string H { get; set; }
    }

    public sealed class ModelK
    {
        public string A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public string E { get; set; }
    }

    public sealed class ModelL
    {
        public int A { get; set; }
        public int B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
        public string F { get; set; }
        public string G { get; set; }
        public decimal H { get; set; }
        public decimal I { get; set; }
        public IList<ModelM> J { get; set; }
        public IList<ModelQ> K { get; set; }
        public IList<ModelR> L { get; set; }
        public IList<ModelS> M { get; set; }
        public IList<ModelH> N { get; set; }
    }

    public sealed class ModelM
    {
        public int A { get; set; }
        public int B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public ICollection<ModelQ> E { get; set; } = new List<ModelQ>();
        public ICollection<ModelR> F { get; set; } = new List<ModelR>();
    }

    public sealed class ModelN
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public double D { get; set; }
        public string E { get; set; }
    }

    public sealed class ModelO
    {
        public string A { get; set; }
        public int B { get; set; }
    }

    public sealed class ModelP
    {
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
    }

    public sealed class ModelQ
    {
        public int A { get; set; }
        public int B { get; set; }
        public decimal C { get; set; }
        public string D { get; set; }
    }

    public sealed class ModelR
    {
        public int A { get; set; }
        public int B { get; set; }
        public decimal C { get; set; }
        public string D { get; set; }
    }

    public sealed class ModelS
    {
        public decimal A { get; set; }
        public string B { get; set; }
    }

    public sealed class ModelT
    {
        public decimal A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public int D { get; set; }
    }

    public sealed class ModelU
    {
        public int A { get; set; }
        public decimal B { get; set; }
        public string C { get; set; }
        public decimal D { get; set; }
    }

    public sealed class ModelV
    {
        public string A { get; set; }
        public decimal B { get; set; }
        public decimal C { get; set; }
    }

    public sealed class ModelW
    {
        public string A { get; set; }
        public decimal B { get; set; }
        public decimal C { get; set; }
    }

    public enum ModelX
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        E = 4,
        F = 5,
        G = 6,
        H = 8,
        I = 9,
        J = 10,
        K = 11,
        L = 12,
    }

    public enum ModelY
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        F = 6,
        G = 7,
    }

    public enum ModelZ
    {
        A = 1,
        B = 2,
    }
}
