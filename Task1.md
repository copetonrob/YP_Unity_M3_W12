# Задание 1: Банановая граната! (В разработке)

## Описание

В этом задании мы реализуем бросок банановой бомбы. Она должна быть прыгучей и взрываться через несколько секунд после броска, нанося урон всем врагам вокруг себя.

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/task1.gif" width="600"/>

## Инструкция

Добавь в проект модель [банана](https://github.com/copetonrob/YP_Unity_M3_W11/blob/main/packages/M3W12_banana.unitypackage)

Добавь в префаб банана компоненты Rigidbody и Mesh Collider. Настрой параметры компонентов. Если изменяешь префаб в сцене, не забудь применить изменения к префабу.

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/banana_prefab.png" width="600"/>

Добавим банану немного прыгучести.

Создай новый физический материал

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/create_physic_material.png" width="400"/>

Настрой параметры физического материала. Увеличь прыгучесть. Примеры настроек:

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/physic_material_settings.png" width="400"/>

Навесь ссылку на материал в коллайдере банана

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/physic_material_ref.png" width="400"/>

Создай скрипт [банановой бомбы](https://github.com/copetonrob/YP_Unity_M3_W11/blob/main/scripts/BananaBomb.cs)

Скопируй содержимое себе в проект и восстанови спрятанные фрагменты кода

Навесь скрипт на префаб банана

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/banana_script.png" width="400"/>

Создай скрипт для [броска банана](https://github.com/copetonrob/YP_Unity_M3_W11/blob/main/scripts/BananaBombLauncher.cs). Это такой же скрипт как в прошлых вебинарах.

Навесь этот скрипт на объект Weapon внутри объекта Player

Навесь ссылку на префаб банана в скрипте BananaBombLauncher.

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/weapon_settings.png" width="400"/>

Запусти сцену, проверь что все работает. Бананы летят и взрывают врагов (пока без визуального и звукового сопровождения, враги просто исчезают)
