# TCR 

## Flujo

el fichero tcr.sh implementa el flujo TCR

```
./scripts/test.sh && ./scripts/commit.sh || ./scripts/revert.sh
```

los diferentes comandos están separados en scripts para facilitar variantes del flujo. Pero podemos lanzar un único comando si lo preferimos:

```
dotnet test && git -am working || git reset --hard
```

## Katas para probar

- [Fibonacci](https://www.codewars.com/kata/553e6558e848c5a3180000bc)
- [Substring kata](https://github.com/540/substring-kata)