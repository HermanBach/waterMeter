# waterMeter
Тестовое задание

Для запуска приложения необходимо:
1. Создать базу данных в Microsoft SQL с именем "WM"
2. Открыть PackageManagerConsole и ввести команду "Update-Database"
4. Открыть SQL Managment Studio и выполнить следующие команды:

INSERT INTO Meter VALUES ('ЗаводскойНомер1', '01.01.01', '01.01.2024')
INSERT INTO Meter VALUES ('ЗаводскойНомер2', '01.01.01', '01.01.2023')
INSERT INTO Meter VALUES ('ЗаводскойНомер3', '01.01.01', '01.01.2023')
INSERT INTO Meter VALUES ('ЗаводскойНомер4', '01.01.01', '01.01.2023')
INSERT INTO Meter VALUES ('ЗаводскойНомер5', '01.01.01', '01.01.2023')
INSERT INTO Meter VALUES ('ЗаводскойНомер6', '01.01.01', '01.01.2024')
INSERT INTO Meter VALUES ('ЗаводскойНомер7', '01.01.01', '01.01.2024')
INSERT INTO Meter VALUES ('ЗаводскойНомер8', '01.01.01', '01.01.2024')
INSERT INTO Meter VALUES ('ЗаводскойНомер9', '01.01.01', '01.01.2024')
INSERT INTO Meter VALUES ('ЗаводскойНомер10', '01.01.01', '01.01.2024')

INSERT INTO Apartment VALUES ('<Пушкина>/<1>/<1>', 1)
INSERT INTO Apartment VALUES ('<Пушкина>/<1>/<2>', 2)
INSERT INTO Apartment VALUES ('<Колотушкина>/<1>/<1>', 3)
INSERT INTO Apartment VALUES ('<Колотушкина>/<1>/<2>', 4)
INSERT INTO Apartment VALUES ('<Ленина>/<1>/<1>', 5)
INSERT INTO Apartment VALUES ('<Ленина>/<2>/<1>', 6)
INSERT INTO Apartment VALUES ('<Ленина>/<2>/<2>', 7)
INSERT INTO Apartment VALUES ('<Ленина>/<3>/<1>', 8)
INSERT INTO Apartment VALUES ('<Ленина>/<3>/<3>', 9)
INSERT INTO Apartment VALUES ('<Ленина>/<3>/<4>', 10)

INSERT INTO MetersData VALUES (1, 111, '01.01.2023')
INSERT INTO MetersData VALUES (1, 222, '01.10.2023')
INSERT INTO MetersData VALUES (1, 333, '01.11.2023')

INSERT INTO MetersData VALUES (2, 111, '01.01.2023')
INSERT INTO MetersData VALUES (2, 222, '01.10.2023')
INSERT INTO MetersData VALUES (2, 333, '01.11.2023')

INSERT INTO MetersData VALUES (3, 111, '01.01.2023')
INSERT INTO MetersData VALUES (3, 222, '01.10.2023')
INSERT INTO MetersData VALUES (3, 333, '01.11.2023')

INSERT INTO MetersData VALUES (4, 111, '01.01.2023')
INSERT INTO MetersData VALUES (4, 222, '01.10.2023')
INSERT INTO MetersData VALUES (4, 333, '01.11.2023')

INSERT INTO MetersData VALUES (5, 111, '01.01.2023')
INSERT INTO MetersData VALUES (5, 222, '01.10.2023')
INSERT INTO MetersData VALUES (5, 333, '01.11.2023')

INSERT INTO MetersData VALUES (6, 111, '01.01.2023')
INSERT INTO MetersData VALUES (6, 222, '01.10.2023')
INSERT INTO MetersData VALUES (6, 333, '01.11.2023')

INSERT INTO MetersData VALUES (7, 111, '01.01.2023')
INSERT INTO MetersData VALUES (7, 222, '01.10.2023')
INSERT INTO MetersData VALUES (7, 333, '01.11.2023')

INSERT INTO MetersData VALUES (8, 111, '01.01.2023')
INSERT INTO MetersData VALUES (8, 222, '01.10.2023')
INSERT INTO MetersData VALUES (8, 333, '01.11.2023')

INSERT INTO MetersData VALUES (9, 111, '01.01.2023')
INSERT INTO MetersData VALUES (9, 222, '01.10.2023')
INSERT INTO MetersData VALUES (9, 333, '01.11.2023')

INSERT INTO MetersData VALUES (10, 111, '01.01.2023')
INSERT INTO MetersData VALUES (10, 222, '01.10.2023')
INSERT INTO MetersData VALUES (10, 333, '01.11.2023')