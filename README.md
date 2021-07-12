# Hospital-Database

Курсовой проект по дисциплине "Системы управления базами данных". Тема - "Больница".

## Задание

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/project_task.png" align="center"
    title="Projcet task">

## Описание ролей

* Администратор. Пользователь, имеющий доступ на уровне администратора может работать напрямую с палатами и больными, а также диагнозами: создавать и удалять. 
* Клиент. Пользователь, имеющий доступ на уровне клиента может регистрироваться.

В данной работе была реализована роль администратора.


## Реализация

Пользовательский интерфейс был написан на языке программирования C#.
Ниже представлена реализация интерфейса для пользователя уровня администратора, который имеет доступ ко всем таблицам базы данных.

### Sign in / up

После запуска программы пользователю предлагается ввести данные своей учётной записи, если она существует или создать новую, если учётной записи у него пока нет.

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/sign_in.png" align="center"
    title="Sign in">

В случае, если у пользователя нету аккаунта, у него имеется возможность создать его путем нажатия на кнопку “Sign Up”

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/sign_up.png" align="center"
    title="Sign up">

Пользователю предлагается придумать себе логин и подтвердить регистрацию паролем. В случае, если пароли не совпадают или были введены не все данные, программа уведомит его в этом.

### Main form

После входа в систему программа встречает пользователя четырьмя основными кнопками:

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/main_form.png" align="center"
    title="Main form">

### Diagnosis table

При нажатии на кнопку “Diagnosis table” пользователь может добавлять диагнозы, удалять и изменять их:

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/diagnosis_table.png" align="center"
    title="Diagnosis table">

Администратор может добавить новый диагноз.

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/add_new_diagnosis.png" align="center"
    title="Add new diagnosis">

Администратор может обновить название диагноза. В случае, если данным диагнозом кто-то болеет, то это наименование невозможно будет изменить, так как сработает триггер.

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/update_diagnosis.png" align="center"
    title="Update diagnosis"> <img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/update_diagnosis_trigger.png" align="center"
    title="Update diagnosis trigger"> 

Так же можно удалить диагноз.

### Wards table

При нажатии на кнопку “Wards table” администратор попадает на следующую форму:

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/wadrs_form.png" align="center"
    title="Wards form">

С довольно похожим функционалом: добавление и удаление палаты.

### Patients table

При нажатии на кнопку “Patients table” администратор видит следующее:

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/patients_form.png" align="center"
    title="Patients form">

С возможностью добавления, удаления и обновления пациента.

### Something form

При нажатии на кнопку “Something” администратор видит следующее:

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/something_form.png" align="center"
    title="Something form">

Первая кнопка – это таблица по всем палатам с количество занятого места:

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/something_form_ward_capacity.png" align="center"
    title="Something form: ward capacity">

Вторая – это таблица по самым популярным диагнозам с количество заболевших:

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/something_form_the_most_popular_diagnosis.png" align="center"
    title="Something form: the most popular diagnosis">

Третья – это хранимая процедура, имеющая два параметра «диагноз1» и «диагноз2». Процедура должна возвращать палаты, где занятых мест меньше, чем среднее количество людей в палатах с этими диагнозами. 

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/something_form_less_than_avg.png" align="center"
    title="Something form: less than avg">

И четвертая – это курсор, результат которого записывается в файл. Хранимая процедура имеет два параметра, определяющие анализируемый диапазон отношения занятого места к свободному (верхняя и нижняя граница диапазона). Результатом работы процедуры должна явиться выборка, содержащая среднюю заполненность по всем палатам в рассматриваемом интервале заполненности в разрезе диагнозов.

<img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/something_form_cursor.png" align="center"
    title="Something form: cursor"> <img src="https://github.com/LeonidVolohov/Hospital-Database/blob/main/Screenshots/something_form_cursor_txt.png" align="center"
    title="Something form: cursor output">
