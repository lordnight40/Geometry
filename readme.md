﻿## Пояснения

Для описания фигуры использовался абстрактный класс `Figure`.  
Сделано это было т.к. мы описывали фундоментальное состояние и признаки объекта, 
т.е. отношение **является**.  
Для этого не был использован интерфейс, потому как я считаю, 
что это описывает отношение **поддерживает**. Т.е. объект поддерживает какой-то функционал.  

Для того, чтобы создать новый вид фигуры, достаточно создать новый класс и унаследовать его от `Figure`.  

Так как все фигуры наследники класса `Figure`, то не обязательно знать конкретный тип фигуры на этапе компиляции, 
он будет определяться в рантайме при вызове метода расчета площади.