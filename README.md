#Задание:

Приложение под ios или android. На сцене отображается небольшой (50px) круг.

    На поле находится N монет;
    На поле находится N шипов;
    При клике по любой точке экрана - круг двигается к месту клика;
    При нескольких последовательных кликах - объект двигается поочередно по всем прокликанным точкам;
    Отображается траектория движения объекта;
    Круг может собирать монеты и отображать их количество в углу;
    Если круг попадает на шип, то лопается и показывается экран с рестартом;
    Если круг собрал все монеты на сцене, то показывается экран с победой и кнопкой рестарт.


###Комментарий:

пункт 4 (При нескольких последовательных кликах - объект двигается поочередно по всем прокликанным точкам;) выполнить не смог, т.к. рассчитывал выполнить задание не больше чем за пару часов, в принципе идея реализации есть.


## о выполненном:

1. Объект GameManager отвечает за спаун игровых объектов (шипов и монет), также он отвечает за вызов экрана Game Over.
2. К объекту Player помимо скрипта управления прикреплен скрипт, отвечающий за сбор монет (и столкновение с шипами)
3. В объекте Canvas расположен игровой интерфейс, отображающий количество собранных монет, а также экран Game Over.