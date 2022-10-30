new x();

class m
{
static Stack<int>  s = new();
public static int  t => s.Pop();
public static char a => (char)s.Pop();
public static int  c { set => s.Push(value); } 
public static int  k => s.Peek();
}


class x
{
public class h
{
public int d = 0;
public int p = 0;


public h() { }
public h(int q, int b)
{
d = q;
p = b;
}

public static h operator+(h b, h q)
{
return (b.d+q.d,b.p+q.p);
}

public static implicit operator h((int, int) v)
{
return new(v.Item1, v.Item2);
}
}



static public h z = new();
static public h w = (1, 0);
public static char[][] W = new char[][]{
">v\0\0\0\0\0\0\0".ToArray(),
"v># #p1#00#10p# <                                                ".ToArray(),
">~>:\">\"-!v>:\"<\"-!v>:\"+\"-!v>:\"-\"-!v>:\".\"-!v>:\",\"-!v>:\"]\"-!v>:\"[\"-!v@".ToArray(),
"^Xg   v00_^v-1g00_^v0:g00_^v0:g00_^v 0g00_^vg000~_^      _^ v<v $_^".ToArray(),
"^ 1   >g1+ >00pv   >g1+\\0pv>g1-\\0pv>g,v  p\\<        v!-\"]\":~<0>\"v\"v".ToArray(),
"^       <  $   <          <       <   <     <      v_\\1p1+: ^^0p58<".ToArray(),
"  ^:+1\\<>:13p\\v                                    > v".ToArray(),
"       | -g31:<>$01-5                       ^5-10-1$$<".ToArray(),
"       >00g:0g!|".ToArray(),
"^        p58\" \"<".ToArray()
};


public delegate void r();
public Dictionary<int, r> p = new();
static volatile internal protected Random a = new();

public static string q = "";
public static int k = 0;

public x()
{
p[' '] = () => { };
p['>'] = () => w = (1, 0);
p['<'] = () => w = (-1, 0);
p['v'] = () => w = (0, 1);
p['^'] = () => w = (0, -1);
p['0'] = () => m.c = 0;
p['1'] = () => m.c = 1;
p['2'] = () => m.c = 2;
p['3'] = () => m.c = 3;
p['4'] = () => m.c = 4;
p['5'] = () => m.c = 5;
p['6'] = () => m.c = 6;
p['7'] = () => m.c = 7;
p['8'] = () => m.c = 8;
p['9'] = () => m.c = 9;
p['+'] = () => m.c = (m.t + m.t);
p['-'] = () => { var a = m.a; m.c = m.t - a; };
p['*'] = () => m.c = (m.t * m.t);
p['/'] = () => { var a = m.t; m.c = (m.t / a); };
p['%'] = () => { var a = m.t; m.c = (m.t % a); };
p['!'] = () => m.c = (m.t != 0 ? 1 : 0);
p['`'] = () => { var a = m.t; m.c = (m.t > a ? 1 : 0); };
p['?'] = () => { var v = a.Next(2); var x = a.Next(2); w = new(v == 0 ? 1 : 0 * x == 0 ? 1 : -1, v == 1 ? 1 : 0 * x == 0 ? 1 : -1); };
p['_'] = () => w = new(m.t == 0 ? -1 : 1, 0);
p['|'] = () => w = new(0, m.t == 0 ? 1 : -1);
p['"'] = () => { Lop: z += w; var x = W[z.p][z.d]; if (x == 34) return; m.c = (x);goto Lop;  };
p[':'] = () => m.c = m.k;
p['\\'] = () => { var x = m.t; var a = m.t; m.c = (x); m.c = (a); };
p['$'] = () => _ = m.t;
p['.'] = () => Console.Write(m.t + " ");
p[','] = () => Console.Write(m.a);
p['#'] = () => z += w;
p['p'] = () => { var y = m.t; var x = m.t; W[y][x] = m.a; };
p['g'] = () => { var y = m.t; var x = m.t; m.c = (W[y][x]); };
p['&'] = () => { var x = int.Parse(q[k..]); m.c = (x); k += x.ToString().Length; };
p['~'] = () => m.c = (q[k++]);
p['@'] = () => Environment.Exit(0);

char[] c = Enumerable.Repeat('+', 48).ToArray();
for (int x = 0; x < 6; x++)
{
int v = (int)Math.Round(10 * (2.33053 - 2.20497 * Math.Sin(0.412066 * x + 2.68413)));
if (v.ToString().Distinct().Count() == 1)
v--;
if (x % 3 == 2 || x == 3)
v++;
if (x == 4)
v--;
c[--v] = '>';
if (x < 4)
c[(int)Math.Round(-.25 * x * x + 2.65 * x + 40.15)] = '.';
if (x < 3)
c[x + 35] = '<';
}
c[11] = '[';
c[12] = '-';
c[38] = ']';
c[47] = 'X';

q = new(c);

Loop:
//y();
p[W[z.p][z.d]]();
do
z += w;
while (W[z.p][z.d] == 32);
goto Loop;
}

static int DL = 0;
static void y()
{
if (DL == 0) return;
Console.SetCursorPosition(0, 0);
Console.ForegroundColor = ConsoleColor.Gray;
for (int i = 0; i < W.Length; i++)
{
if (i == 2 && DL == 1) 
return;
var a = W[i];
foreach (var b in a)
f(b);
Console.Write('\n');}
if (DL == 2) 
return;
Console.SetCursorPosition(z.d, z.p);
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(W[Console.CursorTop][Console.CursorLeft]);
Console.ForegroundColor = ConsoleColor.Gray;
}

static readonly char[] c = { '\0', '\b', '\a', '\n', '\t', '\r', '\v' };
static void f(char x)
{
if (c.Contains(x))
Console.Write( (int)x%10);
else
Console.Write(x);
}}