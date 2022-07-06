C# - Prof. Nélio


- [x] C# e .NET
- [x] Compilação e interpretação
- [x] Estrutura de uma aplicação C#
- [ ] Primeiro programa em C# do curso
- [ ] Estrutura de um programa C#
- [ ] Dicas do Visual Studio






- [x] C# e .NET
    C# -  Ling programaçao(regras sintaticas)

    .NET- Plataforma de desenvolvimento.Pode inclusive usa diversas linguagens(VB, F# e C#)
Composto por : 
    BCL-Biblioteca de classes base( Base class Library)²²diponibiliza varias funcioonalidades (bibliotecas)para usar na sua aplicação
    CLR - A  maquina virtual
Executa os programas como a JVM do JAVA
    CARACTERISITCA INTERESSANTE= GARBAGE COLLECTION->objetos nao utilizados são automaticamente desalocados da memoria
{
    .Net Framework > WPF , Windows Forms ,Console, ASP.NET(.NET FRMWORK BCL)

    .NET CORE >Console e ASP.NET Core (.NET CORE BCL) (nao vem com sistema de criações de janelas desktop e preciso usar outra lib de telas como o Electron, por exemplo)

    Xamarin > IOS ,MacOS e Android (mono BCL)
}
- [x] Compilação e interpretação
                Codigo fonte é o codigo que o programadro faz.Não é entendido pela maquina.Para tanto existem dois processos : Compilação e interpretação
compiladas = C C++
interpretadas = PHP JavaScript
pre-compiladas+vm= Java , C#

Como ocorre : 
                Compilação : um programa especifico para cada SO faz a tradução do codigo para aquele sistema 
    Interpretação ocorre  quando por exemplo no PHP ou JavaScript ocorre um interpretador que converte gradualmente o codigo fote em executavel enquanto ele é executado sem necessidade de compilação e geração de um executavel vantagem : praticidade; desvantagem : processo mais lento que um programa compilado.
                pre-compiladas : o codigo passa pela pre compilação que gera o bytecode (codigo intermediario) que roda em plataformas diferentes. Nao precisa recompilar quando for rodar  plataformas diferentes

u- [x] Estrutura de uma aplicação C#

    Aplicação e composta por classes que representam a sua aplicação
    As classes ão agrupadas em NameSpaces
Ex:
    As classes representam as Entidades de Negocio : Cliente , Produto, Pedido ...representam o negocio e dados que o sistema devem aarmazenar pode ser agruapdas por exemplo em um nameSpace ENTIDADES
Classes que representam serviços : NameSpace Serviços

    Existe tb os Assemblys(DLL ou EXE )que sao agrupamentos fisicos do negocio : Ex : 
Tds NameSpaces relacionados a Financeiro podem ser agrupadas em um Financial , Graficos,3D,2D, Utilitarios podem ser agrupados no Asembly Graphics...etc
 A Aplicação é o Agrupamento de assemblies relacionados


no VisualStudio
 Aplicação == Solution
 Assemblu = =Projec111a
2a,,p

- [ ] Estrutura de um programa C#
Etrutura de arquivos
- [ ] Dicas do Visual Studio