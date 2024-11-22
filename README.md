Создала интерфейс новой задачи - последовательно суммировать числа от 1 до 50:
[DistributedQueue.Common/Interface1.cs](https://github.com/ShimarevaMA/DistributedQueue/blob/58947ffe11393e2607b356175de86cdb83ef56a5/DistributedQueue.Common/Interface1.cs)

Далее я реализовала метод:
https://github.com/ShimarevaMA/DistributedQueue/blob/58947ffe11393e2607b356175de86cdb83ef56a5/DistributedQueue.Worker/Class1.cs

 где:
  - Task Sum50(string name, CancellationToken token): метод принимает два параметра — name, который может использоваться для идентификации вычисления, и token, который позволяет отменять выполнение задачи.

  - Запуск задачи:
    - var startTime = DateTime.Now; захватывает текущее время, чтобы отметить начало вычислений.
    - Console.Write($"{startTime}: Started compute: "); выводит на консоль время начала и сообщение о начале вычисления.

  - Цикл вычислений:
    - Цикл for (int i = 1; i <= 50; i++) последовательно суммирует числа от 1 до 50.
    - sum += i; добавляет текущее значение i к переменной sum.
    - Console.WriteLine($"Сумма чисел от 1 до {i}: {sum}"); выводит на консоль промежуточную сумму чисел от 1 до текущего i.

  - Проверка на отмену:
    - if (token.IsCancellationRequested) проверяет, был ли получен сигнал на отмену задачи. Если да, выводится сообщение о том, что вычисление отменено, и цикл прерывается.

  - Завершение задачи:
    - После выхода из цикла, независимо от того, было ли завершено суммирование или оно было отменено, выводится сообщение о завершении задачи.

В конце я назначила выполнение данной задачи на клавишу "R":
[DistributedQueue/Program.cs
](https://github.com/ShimarevaMA/DistributedQueue/blob/a33cc676363901fa69a53caf925641436c20820e/DistributedQueue/Program.cs)
