# Задание 2: Добавляем звуки и эффекты!

## Описание

В этом задании мы добавим эффекты взрыва и звуки для банановой бомбы

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/task2.gif" width="600"/>

## Инструкция

Добавь в проект [unity package](https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/packages/BananaExplosion.unitypackage) с эффектом взрыва

Добавь в проект [звуковой файл](https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/packages/boink.mp3) для столкновения банана с объектами

Чтобы мы услышали в игре звук, на объекте должен быть компонент AudioSource. Добавь этот компонент на префаб банана.

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/audio_component.png" width="600"/>

Укажи ссылку на звуковой файл в параметре AudioClip

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/AudioSource.png" width="400"/>

Теперь немного модифицируем скрипт банановой бомбы.

Для того, чтобы бананавая бомба запускала звуки и эффект взрыва, необходимо прокинуть ссылки на эти объекты

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/script_effects_ref.png" width="400"/>

Обработаем столкновение с другими коллайдерами, чтобы запустить звук. Добавь в конец скрипта метод OnCollisionEnter

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/collision_sound.png" width="400"/>

Теперь при любом столкновении будет проигрываться звук пружинки

Остается еще один шаг: запуск эффекта взрыва. В конце метода Explode добавь создание копии префаба эффекта взрыва.

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/explode_effect.png" width="600"/>

В префабе банана навесь ссылки в скрипте на AudioSource и на префаб взрыва из пака

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/banana_script_refs.png" width="400"/>

Почти все готово, остался последний штрих. Чтобы эффекты взрыва не засоряли сцену, лучше их уничтожать после конца анимации. Для этого в префабе взрыва в компоненте Particle System можно выставить Stop Action -> Destroy

<img src="https://github.com/copetonrob/YP_Unity_M3_W12/blob/main/img/stop_action.png" width="400"/>

Запусти проект, проверь что все работает!

