string[] maior = Console.ReadLine().Split(' ');
int n1 = int.Parse(maior[0]);
int n2 = int.Parse(maior[1]);
int n3 = int.Parse(maior[2]);


int m ;
int n ;
if (n1 > n2 && n1 > n3) {
m = n1;
}
else if (n2 > n3) {
m = n2;
}
else {
m = n3;
}
if (n1 < n2 && n1 < n3) {
n = n1;
}
else if (n2 < n3) {
n = n2;
}
else {
n = n3;
}


Console.WriteLine($"{m} e o maior e {n} é o menor");
