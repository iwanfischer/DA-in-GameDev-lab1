# АНАЛИЗ ДАННЫХ И ИСКУССТВЕННЫЙ ИНТЕЛЛЕКТ [in GameDev]
Отчет по лабораторной работе #2 выполнил(а):
- Фишер Иван Викторович
- РИ-300032
Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | # | 20 |
| Задание 3 | # | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

## Данные о работе:
Программные пакеты для работы с устройствами дополненной и виртуальной реальности

## Цель работы:
Изучить работу пакета Unity XR, настройку VR оборудования, запуск VR проекта через настроенное оборудование.

## Задание 1
### Пошагово выполнить каждый пункт раздела "ход работы" с описанием и примерами реализации задач
Ход работы:
- 1 - Пошагово выполнить каждый пункт по примеру предоставленных
видеоматериалов:
- 2 – Создайте новый Unity проект из шаблона 3D-Core;
- 3 – Откройте вкладку Edit -> Project settings;
- 4 – Установите XR Plugin Management;
- 5 – Настройте XR Plugin Management на работу через SDK OpenXR;
- 6 – Настройте режим рендера VR на каждый глаз;
- 7 – Добавить поддержку контроллеров вашего оборудования;
- 8 – Через вкладку Windows -> Pacage Manager добавьте и установите пакет
com.unity.xr.interaction.toolkit;
- 9 – Импортируйте Starter Assets из установленного пакета;
- 10 – Настройте Input system на основе импортированного Starter Assets;
- 11 – Скачайте и установите Steam и Steam VR;
- 12 – Настройте и подключите к PC ваше VR оборудование;
- 13 – Вернитесь в Unity и настройте запуск проекта через SteamVR;
- 14– Добавьте объект Plane;
- 15– Добавьте на сцену объект XR-Orig (Action Base);
- 16 – На объект XR Interaction Manager создайте компонент Input Action
Manager;
- 17– Добавьте в Input Action Manager настроенный Input System;
- 18– Запустите проект и убедитесь, что он воспроизводится на VR
оборудовании.
![1-7](https://user-images.githubusercontent.com/41534344/195061943-0c1ca7ca-9646-4bc7-8298-0df495de65dc.png)
![8](https://user-images.githubusercontent.com/41534344/195061952-ebae814b-ad24-4fd3-a24e-996de6303ec1.png)
![9-10](https://user-images.githubusercontent.com/41534344/195061958-b1644db3-343a-4c6b-82c6-edbe4d6dc9c2.png)
![14-17](https://user-images.githubusercontent.com/41534344/195061961-1bc5ca16-2a6c-4952-96e6-0fd0c3f6d4b0.png)



## Задание 2
### Привести ответ на вопросы:

1. Что значит X в аббревиатуре XR?
	- Сокращение под которое можно подставить AR, VR, MR
2. Какие SDK поддерживает XR Plugin Management по Default?
	- ARCore
	- Oculus
	- OpenXR
	- Unity Mock HMD



## Задание 3
### Какова роль параметра Lr? Ответьте на вопрос, приведите пример выполнения кода, который подтверждает ваш ответ. В качестве эксперимента можете изменить значение параметра.

- Перечисленные в этом туториале действия могут быть выполнены запуском на исполнение скрипт-файла, доступного [в репозитории](https://github.com/Den1sovDm1triy/hfss-scripting/blob/main/ScreatingSphereInAEDT.py).
- Для запуска скрипт-файла откройте Ansys Electronics Desktop. Перейдите во вкладку [Automation] - [Run Script] - [Выберите файл с именем ScreatingSphereInAEDT.py из репозитория].

```py

import ScriptEnv
ScriptEnv.Initialize("Ansoft.ElectronicsDesktop")
oDesktop.RestoreWindow()
oProject = oDesktop.NewProject()
oProject.Rename("C:/Users/denisov.dv/Documents/Ansoft/SphereDIffraction.aedt", True)
oProject.InsertDesign("HFSS", "HFSSDesign1", "HFSS Terminal Network", "")
oDesign = oProject.SetActiveDesign("HFSSDesign1")
oEditor = oDesign.SetActiveEditor("3D Modeler")
oEditor.CreateSphere(
	[
		"NAME:SphereParameters",
		"XCenter:="		, "0mm",
		"YCenter:="		, "0mm",
		"ZCenter:="		, "0mm",
		"Radius:="		, "1.0770329614269mm"
	], 
)

```

## Выводы

Абзац умных слов о том, что было сделано и что было узнано.

| Plugin | README |
| ------ | ------ |
| Dropbox | [plugins/dropbox/README.md][PlDb] |
| GitHub | [plugins/github/README.md][PlGh] |
| Google Drive | [plugins/googledrive/README.md][PlGd] |
| OneDrive | [plugins/onedrive/README.md][PlOd] |
| Medium | [plugins/medium/README.md][PlMe] |
| Google Analytics | [plugins/googleanalytics/README.md][PlGa] |

## Powered by

**BigDigital Team: Denisov | Fadeev | Panov**
