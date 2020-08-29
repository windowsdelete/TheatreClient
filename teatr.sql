-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Ноя 28 2019 г., 13:55
-- Версия сервера: 10.3.13-MariaDB
-- Версия PHP: 7.1.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `teatr`
--

-- --------------------------------------------------------

--
-- Структура таблицы `abonimenty`
--

CREATE TABLE `abonimenty` (
  `id_Abonimenty` int(11) NOT NULL,
  `id_Zhanry` int(11) NOT NULL,
  `AbonimentCost` int(11) DEFAULT NULL,
  `AbonimentBuyDate` datetime DEFAULT NULL,
  `AbonimentOutDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `abonimenty`
--

INSERT INTO `abonimenty` (`id_Abonimenty`, `id_Zhanry`, `AbonimentCost`, `AbonimentBuyDate`, `AbonimentOutDate`) VALUES
(1, 1, 3234, '2019-04-21 10:33:49', '2019-04-28 10:33:49'),
(2, 2, 2131, '2019-04-18 20:15:06', '2019-04-25 20:15:06'),
(3, 3, 4213, '2019-04-21 11:07:52', '2019-04-28 11:07:52'),
(4, 4, 2313, '2019-04-19 16:04:50', '2019-04-24 16:04:50'),
(5, 2, 3420, '2019-10-27 13:25:13', '2019-11-03 13:25:13'),
(7, 3, 2000, '2019-10-26 13:29:12', '2019-11-02 13:29:12'),
(19, 1, 2320, '2019-10-29 11:10:50', '2019-11-05 11:10:50');

--
-- Триггеры `abonimenty`
--
DELIMITER $$
CREATE TRIGGER `abonimentylogDelete` BEFORE DELETE ON `abonimenty` FOR EACH ROW BEGIN
INSERT INTO abonimentybkp SET
abonimentybkp.id_Zhanry_old=OLD.Id_Zhanry,
abonimentybkp.AbonimentCost_old=OLD.AbonimentCost,
abonimentybkp.AbonimentBuyDate_old=OLD.AbonimentBuyDate,
abonimentybkp.AbonimentOutDate_old=OLD.AbonimentOutDate,
abonimentybkp.ID=OLD.ID_abonimenty;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_abonimenty,
teatrlog.NameTable='Абонименты';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `abonimentylogInsert` AFTER INSERT ON `abonimenty` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_abonimenty,
teatrlog.NameTable='Абонименты';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `abonimentylogUpdate` BEFORE UPDATE ON `abonimenty` FOR EACH ROW BEGIN 
INSERT INTO abonimentybkp SET 
abonimentybkp.id_Zhanry_old=OLD.Id_Zhanry,
abonimentybkp.AbonimentCost_old=OLD.AbonimentCost,
abonimentybkp.AbonimentBuyDate_old=OLD.AbonimentBuyDate,
abonimentybkp.AbonimentOutDate_old=OLD.AbonimentOutDate,
abonimentybkp.ID=OLD.ID_abonimenty;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_abonimenty,
teatrlog.NameTable='Абонименты';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `abonimentybkp`
--

CREATE TABLE `abonimentybkp` (
  `id_BKP` int(11) NOT NULL,
  `id_Zhanry_old` int(11) DEFAULT NULL,
  `AbonimentCost_old` int(11) DEFAULT NULL,
  `AbonimentBuyDate_old` datetime DEFAULT NULL,
  `AbonimentOutDate_old` datetime DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `abonimentybkp`
--

INSERT INTO `abonimentybkp` (`id_BKP`, `id_Zhanry_old`, `AbonimentCost_old`, `AbonimentBuyDate_old`, `AbonimentOutDate_old`, `ID`) VALUES
(2, 1, 2222, '2019-10-29 11:07:00', '2019-11-05 11:07:00', 18),
(3, 1, 2211, '2019-10-29 11:07:00', '2019-11-05 11:07:00', 18);

-- --------------------------------------------------------

--
-- Структура таблицы `auditory`
--

CREATE TABLE `auditory` (
  `id_Auditory` int(11) NOT NULL,
  `NameAuditory` char(50) DEFAULT NULL,
  `Vmestimost` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `auditory`
--

INSERT INTO `auditory` (`id_Auditory`, `NameAuditory`, `Vmestimost`) VALUES
(1, 'Большой зал', 500),
(2, 'Средний зал', 300),
(3, 'Малый зал', 200);

--
-- Триггеры `auditory`
--
DELIMITER $$
CREATE TRIGGER `auditorylogDelete` BEFORE DELETE ON `auditory` FOR EACH ROW BEGIN
INSERT INTO auditorybkp SET
auditorybkp.NameAuditory_old=OLD.NameAuditory,
auditorybkp.Vmestimost_old=OLD.Vmestimost,
auditorybkp.ID=OLD.ID_auditory;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_auditory,
teatrlog.NameTable='Аудитории';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `auditorylogInsert` AFTER INSERT ON `auditory` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_auditory,
teatrlog.NameTable='Аудитории';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `auditorylogUpdate` BEFORE UPDATE ON `auditory` FOR EACH ROW BEGIN 
INSERT INTO auditorybkp SET 
auditorybkp.NameAuditory_old=OLD.NameAuditory,
auditorybkp.Vmestimost_old=OLD.Vmestimost,
auditorybkp.ID=OLD.ID_auditory;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_auditory,
teatrlog.NameTable='Аудитории';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `auditorybkp`
--

CREATE TABLE `auditorybkp` (
  `id_BKP` int(11) NOT NULL,
  `NameAuditory_old` char(50) DEFAULT NULL,
  `Vmestimost_old` int(11) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `auditorybkp`
--

INSERT INTO `auditorybkp` (`id_BKP`, `NameAuditory_old`, `Vmestimost_old`, `ID`) VALUES
(1, 'Микро-аудитория', 2, 5),
(2, 'Микро-аудитория', 7, 5);

-- --------------------------------------------------------

--
-- Структура таблицы `auth`
--

CREATE TABLE `auth` (
  `id_Auth` int(11) NOT NULL,
  `Log` char(50) DEFAULT NULL,
  `Pass` char(50) DEFAULT NULL,
  `Role` char(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `auth`
--

INSERT INTO `auth` (`id_Auth`, `Log`, `Pass`, `Role`) VALUES
(1, 'a', '1', '0'),
(2, 'log', 'pass', '1'),
(3, 'guest', 'guest', '2'),
(4, 'root', 'toor', '3');

-- --------------------------------------------------------

--
-- Структура таблицы `autors`
--

CREATE TABLE `autors` (
  `id_Autors` int(11) NOT NULL,
  `NameAutor` char(50) DEFAULT NULL,
  `CountryAutor` char(50) DEFAULT NULL,
  `VekAutor` char(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `autors`
--

INSERT INTO `autors` (`id_Autors`, `NameAutor`, `CountryAutor`, `VekAutor`) VALUES
(1, 'Анжелика Холина', 'Литва', '20'),
(2, 'Михаил Афанасьевич Булгаков', 'Россия', '19'),
(3, 'Леонид Генрихович Зорин', 'Азербайджан', '20'),
(4, 'Марюс Ивашкявичюс', 'Литва', '20'),
(5, 'Александр Анатольевич Ширвиндт', 'Россия', '20'),
(6, 'Иван Сергеевич Шмелёв', 'Россия', '19');

--
-- Триггеры `autors`
--
DELIMITER $$
CREATE TRIGGER `autorslogDelete` BEFORE DELETE ON `autors` FOR EACH ROW BEGIN
INSERT INTO autorsbkp SET
autorsbkp.NameAutor_old=OLD.NameAutor,
autorsbkp.CountryAutor_old=OLD.CountryAutor,
autorsbkp.VekAutor_old=OLD.VekAutor,
autorsbkp.ID=OLD.ID_autors;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_autors,
teatrlog.NameTable='Авторы';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `autorslogInsert` AFTER INSERT ON `autors` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_autors,
teatrlog.NameTable='Авторы';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `autorslogUpdate` BEFORE UPDATE ON `autors` FOR EACH ROW BEGIN 
INSERT INTO autorsbkp SET 
autorsbkp.NameAutor_old=OLD.NameAutor,
autorsbkp.CountryAutor_old=OLD.CountryAutor,
autorsbkp.VekAutor_old=OLD.VekAutor,
autorsbkp.ID=OLD.ID_autors;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_autors,
teatrlog.NameTable='Авторы';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `autorsbkp`
--

CREATE TABLE `autorsbkp` (
  `id_BKP` int(11) NOT NULL,
  `NameAutor_old` char(50) DEFAULT NULL,
  `CountryAutor_old` char(50) DEFAULT NULL,
  `VekAutor_old` char(2) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `autorsbkp`
--

INSERT INTO `autorsbkp` (`id_BKP`, `NameAutor_old`, `CountryAutor_old`, `VekAutor_old`, `ID`) VALUES
(1, 'Анжелика Холина', 'Литва', '20', 1),
(2, 'Лев Николаевич Толстой', 'Россия', '19', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `dolzhnosti`
--

CREATE TABLE `dolzhnosti` (
  `id_Dolzhnosti` int(11) NOT NULL,
  `NameDolzhnosti` char(50) DEFAULT NULL,
  `ZP` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `dolzhnosti`
--

INSERT INTO `dolzhnosti` (`id_Dolzhnosti`, `NameDolzhnosti`, `ZP`) VALUES
(1, 'Актер', 75000),
(2, 'Музыкант', 70000),
(3, 'Постановщик', 50000),
(4, 'Служащий', 30000);

--
-- Триггеры `dolzhnosti`
--
DELIMITER $$
CREATE TRIGGER `dolzhnostilogDelete` BEFORE DELETE ON `dolzhnosti` FOR EACH ROW BEGIN
INSERT INTO dolzhnostibkp SET
dolzhnostibkp.NameDolzhnosti_old=OLD.NameDolzhnosti,
dolzhnostibkp.ZP_old=OLD.ZP,
dolzhnostibkp.ID=OLD.ID_dolzhnosti;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_dolzhnosti,
teatrlog.NameTable='Должности';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `dolzhnostilogInsert` AFTER INSERT ON `dolzhnosti` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_dolzhnosti,
teatrlog.NameTable='Должности';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `dolzhnostilogUpdate` BEFORE UPDATE ON `dolzhnosti` FOR EACH ROW BEGIN 
INSERT INTO dolzhnostibkp SET 
dolzhnostibkp.NameDolzhnosti_old=OLD.NameDolzhnosti,
dolzhnostibkp.ZP_old=OLD.ZP,
dolzhnostibkp.ID=OLD.ID_dolzhnosti;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_dolzhnosti,
teatrlog.NameTable='Должности';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `dolzhnostibkp`
--

CREATE TABLE `dolzhnostibkp` (
  `id_BKP` int(11) NOT NULL,
  `NameDolzhnosti_old` char(50) DEFAULT NULL,
  `ZP_old` int(11) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `gastroli`
--

CREATE TABLE `gastroli` (
  `id_Gastroli` int(11) NOT NULL,
  `City` char(50) DEFAULT NULL,
  `SDate` datetime DEFAULT NULL,
  `id_Spektakli` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `gastroli`
--

INSERT INTO `gastroli` (`id_Gastroli`, `City`, `SDate`, `id_Spektakli`) VALUES
(1, 'Москва', '2019-04-18 22:00:00', 1),
(2, 'Казань', '2019-04-19 22:30:00', 3),
(3, 'Пермь', '2019-04-14 11:00:00', 4);

--
-- Триггеры `gastroli`
--
DELIMITER $$
CREATE TRIGGER `gastrolilogDelete` BEFORE DELETE ON `gastroli` FOR EACH ROW BEGIN
INSERT INTO gastrolibkp SET
gastrolibkp.City_old=OLD.City,
gastrolibkp.SDate_old=OLD.SDate,
gastrolibkp.id_Spektakli_old=OLD.id_Spektakli,
gastrolibkp.ID=OLD.ID_gastroli;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_gastroli,
teatrlog.NameTable='Гастроли';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `gastrolilogInsert` AFTER INSERT ON `gastroli` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_gastroli,
teatrlog.NameTable='Гастроли';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `gastrolilogUpdate` BEFORE UPDATE ON `gastroli` FOR EACH ROW BEGIN 
INSERT INTO gastrolibkp SET 
gastrolibkp.City_old=OLD.City,
gastrolibkp.SDate_old=OLD.SDate,
gastrolibkp.id_Spektakli_old=OLD.id_Spektakli,
gastrolibkp.ID=OLD.ID_gastroli;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_gastroli,
teatrlog.NameTable='Гастроли';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `gastrolibkp`
--

CREATE TABLE `gastrolibkp` (
  `id_BKP` int(11) NOT NULL,
  `City_old` char(50) DEFAULT NULL,
  `SDate_old` datetime DEFAULT NULL,
  `id_Spektakli_old` int(11) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `gastrolibkp`
--

INSERT INTO `gastrolibkp` (`id_BKP`, `City_old`, `SDate_old`, `id_Spektakli_old`, `ID`) VALUES
(1, 'Питер', '2019-10-30 11:11:11', 5, 5),
(2, 'Санкт-Петербург', '2019-10-30 11:11:11', 5, 5);

-- --------------------------------------------------------

--
-- Структура таблицы `givezvanie`
--

CREATE TABLE `givezvanie` (
  `id_GiveZvanie` int(11) NOT NULL,
  `id_Rabotniki` int(11) NOT NULL,
  `id_Zvanie` int(11) NOT NULL,
  `DateGiveZvanie` date DEFAULT NULL,
  `Konkurs` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `givezvanie`
--

INSERT INTO `givezvanie` (`id_GiveZvanie`, `id_Rabotniki`, `id_Zvanie`, `DateGiveZvanie`, `Konkurs`) VALUES
(1, 1, 1, '2019-01-10', 'Первая национальная премия'),
(2, 3, 2, '2019-01-20', 'Вторая национальная премия'),
(3, 5, 1, '2019-01-06', 'Третья национальная премия'),
(4, 7, 2, '2019-01-14', 'Вторая национальная премия'),
(5, 9, 1, '2019-01-17', 'Вторая национальная премия');

--
-- Триггеры `givezvanie`
--
DELIMITER $$
CREATE TRIGGER `givezvanielogDelete` BEFORE DELETE ON `givezvanie` FOR EACH ROW BEGIN
INSERT INTO givezvaniebkp SET
givezvaniebkp.id_Rabotniki_old=OLD.id_Rabotniki,
givezvaniebkp.id_Zvanie_old=OLD.id_Zvanie,
givezvaniebkp.DateGiveZvanie_old=OLD.DateGiveZvanie,
givezvaniebkp.Konkurs_old=OLD.Konkurs,
givezvaniebkp.ID=OLD.ID_givezvanie;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_givezvanie,
teatrlog.NameTable='Выдача званий';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `givezvanielogInsert` AFTER INSERT ON `givezvanie` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_givezvanie,
teatrlog.NameTable='Выдача званий';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `givezvanielogUpdate` BEFORE UPDATE ON `givezvanie` FOR EACH ROW BEGIN 
INSERT INTO givezvaniebkp SET 
givezvaniebkp.id_Rabotniki_old=OLD.id_Rabotniki,
givezvaniebkp.id_Zvanie_old=OLD.id_Zvanie,
givezvaniebkp.DateGiveZvanie_old=OLD.DateGiveZvanie,
givezvaniebkp.Konkurs_old=OLD.Konkurs,
givezvaniebkp.ID=OLD.ID_givezvanie;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_givezvanie,
teatrlog.NameTable='Выдача званий';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `givezvaniebkp`
--

CREATE TABLE `givezvaniebkp` (
  `id_BKP` int(11) NOT NULL,
  `id_Rabotniki_old` int(11) DEFAULT NULL,
  `id_Zvanie_old` int(11) DEFAULT NULL,
  `DateGiveZvanie_old` datetime DEFAULT NULL,
  `Konkurs_old` char(50) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_autor_select_country`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_autor_select_country` (
`NameAutor` char(50)
,`CountryAutor` char(50)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_autor_select_vek`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_autor_select_vek` (
`NameAutor` char(50)
,`VekAutor` char(2)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_autor_select_zhanry`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_autor_select_zhanry` (
`NameAutor` char(50)
,`NameZhanry` char(11)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_autor_spektakli`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_autor_spektakli` (
`NameSpektakli` char(50)
,`NameAutor` char(50)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_count_sell_tickets_all_spektakli`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_count_sell_tickets_all_spektakli` (
`NameSpektakli` char(50)
,`Количество` bigint(21)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_count_sell_tickets_select_spektakli`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_count_sell_tickets_select_spektakli` (
`NameSpektakli` char(50)
,`Количество` bigint(21)
,`BuyDate` datetime
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_date_all_done_spektakli`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_date_all_done_spektakli` (
`NameSpektakli` char(50)
,`SDate` datetime
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_description_tickets_date_spektakli`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_description_tickets_date_spektakli` (
`NameSpektakli` char(50)
,`Количество` bigint(21)
,`BuyDate` datetime
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_rabotniki_date_gastroli`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_rabotniki_date_gastroli` (
`F_Rabotniki` char(50)
,`I_Rabotniki` char(50)
,`O_Rabotniki` char(50)
,`NameDolzhnosti` char(50)
,`NameSpektakli` char(50)
,`SDate` datetime
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_rabotniki_date_givezvanie`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_rabotniki_date_givezvanie` (
`F_Rabotniki` char(50)
,`I_Rabotniki` char(50)
,`O_Rabotniki` char(50)
,`NameZvanie` char(30)
,`DateGiveZvanie` date
,`Konkurs` char(50)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_rabotniki_givezvanie_bdate`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_rabotniki_givezvanie_bdate` (
`F_Rabotniki` char(50)
,`I_Rabotniki` char(50)
,`O_Rabotniki` char(50)
,`BDate` date
,`NameZvanie` char(30)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_rabotniki_givezvanie_pol`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_rabotniki_givezvanie_pol` (
`F_Rabotniki` char(50)
,`I_Rabotniki` char(50)
,`O_Rabotniki` char(50)
,`Pol` char(7)
,`NameZvanie` char(30)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_rabotniki_select_bdate`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_rabotniki_select_bdate` (
`F_Rabotniki` char(50)
,`I_Rabotniki` char(50)
,`O_Rabotniki` char(50)
,`BDate` date
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_rabotniki_select_pol`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_rabotniki_select_pol` (
`F_Rabotniki` char(50)
,`I_Rabotniki` char(50)
,`O_Rabotniki` char(50)
,`Pol` char(7)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_rabotniki_select_roles`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_rabotniki_select_roles` (
`F_Rabotniki` char(50)
,`I_Rabotniki` char(50)
,`O_Rabotniki` char(50)
,`NameRole` char(50)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_rabotniki_select_spektakli`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_rabotniki_select_spektakli` (
`NameSpektakli` char(50)
,`F_Rabotniki` char(50)
,`I_Rabotniki` char(50)
,`O_Rabotniki` char(50)
,`NameDolzhnosti` char(50)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_rabotniki_select_zp`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_rabotniki_select_zp` (
`F_Rabotniki` char(50)
,`I_Rabotniki` char(50)
,`O_Rabotniki` char(50)
,`ZP` int(11)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_roles_date_rabotniki`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_roles_date_rabotniki` (
`F_Rabotniki` char(50)
,`I_Rabotniki` char(50)
,`O_Rabotniki` char(50)
,`NameRole` char(50)
,`SetDate` date
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_roles_rabotniki_select_autor`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_roles_rabotniki_select_autor` (
`F_Rabotniki` char(50)
,`I_Rabotniki` char(50)
,`O_Rabotniki` char(50)
,`NameRole` char(50)
,`NameAutor` char(50)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_roles_rabotniki_select_zhanry`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_roles_rabotniki_select_zhanry` (
`F_Rabotniki` char(50)
,`I_Rabotniki` char(50)
,`O_Rabotniki` char(50)
,`NameRole` char(50)
,`NameZhanry` char(11)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_spektakli_done_select_date`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_spektakli_done_select_date` (
`NameSpektakli` char(50)
,`SDate` datetime
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_spektakli_select_autor`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_spektakli_select_autor` (
`NameSpektakli` char(50)
,`NameZhanry` char(11)
,`NameAutor` char(50)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_spektakli_select_country`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_spektakli_select_country` (
`NameSpektakli` char(50)
,`NameZhanry` char(11)
,`NameAutor` char(50)
,`CountryAutor` char(50)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_spektakli_select_vek`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_spektakli_select_vek` (
`NameSpektakli` char(50)
,`NameZhanry` char(11)
,`NameAutor` char(50)
,`VekAutor` char(2)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_spektakli_select_zhanry`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_spektakli_select_zhanry` (
`NameSpektakli` char(50)
,`NameZhanry` char(11)
);

-- --------------------------------------------------------

--
-- Дублирующая структура для представления `give_summ_tickets_select_spektakli`
-- (См. Ниже фактическое представление)
--
CREATE TABLE `give_summ_tickets_select_spektakli` (
`NameSpektakli` char(50)
,`Сумма` decimal(32,0)
);

-- --------------------------------------------------------

--
-- Структура таблицы `groups`
--

CREATE TABLE `groups` (
  `id_Groups` int(11) NOT NULL,
  `NameGroups` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `groups`
--

INSERT INTO `groups` (`id_Groups`, `NameGroups`) VALUES
(1, 'Первая группа'),
(2, 'Вторая группа'),
(3, 'Третья группа');

--
-- Триггеры `groups`
--
DELIMITER $$
CREATE TRIGGER `groupslogDelete` BEFORE DELETE ON `groups` FOR EACH ROW BEGIN
INSERT INTO groupsbkp SET
groupsbkp.NameGroups_old=OLD.NameGroups,
groupsbkp.ID=OLD.ID_groups;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_groups,
teatrlog.NameTable='Группы';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `groupslogInsert` AFTER INSERT ON `groups` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_groups,
teatrlog.NameTable='Группы';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `groupslogUpdate` BEFORE UPDATE ON `groups` FOR EACH ROW BEGIN 
INSERT INTO groupsbkp SET 
groupsbkp.NameGroups_old=OLD.NameGroups,
groupsbkp.ID=OLD.ID_groups;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_groups,
teatrlog.NameTable='Группы';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `groupsbkp`
--

CREATE TABLE `groupsbkp` (
  `id_BKP` int(11) NOT NULL,
  `NameGroups_old` char(50) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `naznachenie`
--

CREATE TABLE `naznachenie` (
  `id_Naznachenie` int(11) NOT NULL,
  `id_Rabotniki` int(11) NOT NULL,
  `id_Groups` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `naznachenie`
--

INSERT INTO `naznachenie` (`id_Naznachenie`, `id_Rabotniki`, `id_Groups`) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 2),
(5, 5, 3),
(6, 6, 1),
(7, 7, 1),
(8, 8, 3),
(9, 9, 2),
(10, 10, 1),
(11, 11, 3),
(12, 12, 1),
(13, 13, 3),
(14, 14, 2),
(15, 15, 2);

--
-- Триггеры `naznachenie`
--
DELIMITER $$
CREATE TRIGGER `naznachenielogDelete` BEFORE DELETE ON `naznachenie` FOR EACH ROW BEGIN
INSERT INTO naznacheniebkp SET
naznacheniebkp.id_Rabotniki_old=OLD.id_Rabotniki,
naznacheniebkp.id_Groups_old=OLD.id_Groups,
naznacheniebkp.ID=OLD.ID_naznachenie;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_naznachenie,
teatrlog.NameTable='Назначение';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `naznachenielogInsert` AFTER INSERT ON `naznachenie` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_naznachenie,
teatrlog.NameTable='Назначение';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `naznachenielogUpdate` BEFORE UPDATE ON `naznachenie` FOR EACH ROW BEGIN 
INSERT INTO naznacheniebkp SET 
naznacheniebkp.id_Rabotniki_old=OLD.id_Rabotniki,
naznacheniebkp.id_Groups_old=OLD.id_Groups,
naznacheniebkp.ID=OLD.ID_naznachenie;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_naznachenie,
teatrlog.NameTable='Назначение';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `naznacheniebkp`
--

CREATE TABLE `naznacheniebkp` (
  `id_BKP` int(11) NOT NULL,
  `id_Rabotniki_old` int(11) DEFAULT NULL,
  `id_Groups_old` int(11) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `priem`
--

CREATE TABLE `priem` (
  `id_Priem` int(11) NOT NULL,
  `id_Rabotniki` int(11) NOT NULL,
  `id_Dolzhnosti` int(11) NOT NULL,
  `PriemDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `priem`
--

INSERT INTO `priem` (`id_Priem`, `id_Rabotniki`, `id_Dolzhnosti`, `PriemDate`) VALUES
(1, 1, 1, '2018-08-07'),
(2, 2, 2, '2018-03-11'),
(3, 3, 1, '2018-08-02'),
(4, 4, 2, '2018-02-25'),
(5, 5, 1, '2018-05-30'),
(6, 6, 2, '2018-06-13'),
(7, 7, 1, '2018-07-10'),
(8, 8, 2, '2018-08-19'),
(9, 9, 1, '2018-03-09'),
(10, 10, 2, '2018-04-06'),
(11, 11, 3, '2018-05-05'),
(12, 12, 4, '2018-04-01'),
(13, 13, 3, '2018-07-14'),
(14, 14, 4, '2018-04-10'),
(15, 15, 4, '2018-04-15');

--
-- Триггеры `priem`
--
DELIMITER $$
CREATE TRIGGER `priemlogDelete` BEFORE DELETE ON `priem` FOR EACH ROW BEGIN
INSERT INTO priembkp SET
priembkp.id_Rabotniki_old=OLD.id_Rabotniki,
priembkp.id_Dolzhnosti_old=OLD.id_Dolzhnosti,
priembkp.PriemDate_old=OLD.PriemDate,
priembkp.ID=OLD.ID_priem;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_priem,
teatrlog.NameTable='Прием';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `priemlogInsert` AFTER INSERT ON `priem` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_priem,
teatrlog.NameTable='Прием';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `priemlogUpdate` BEFORE UPDATE ON `priem` FOR EACH ROW BEGIN 
INSERT INTO priembkp SET 
priembkp.id_Rabotniki_old=OLD.id_Rabotniki,
priembkp.id_Dolzhnosti_old=OLD.id_Dolzhnosti,
priembkp.PriemDate_old=OLD.PriemDate,
priembkp.ID=OLD.ID_priem;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_priem,
teatrlog.NameTable='Прием';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `priembkp`
--

CREATE TABLE `priembkp` (
  `id_BKP` int(11) NOT NULL,
  `id_Rabotniki_old` int(11) DEFAULT NULL,
  `id_Dolzhnosti_old` int(11) DEFAULT NULL,
  `PriemDate_old` date DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `priembkp`
--

INSERT INTO `priembkp` (`id_BKP`, `id_Rabotniki_old`, `id_Dolzhnosti_old`, `PriemDate_old`, `ID`) VALUES
(1, 3, 1, '2018-08-02', 3),
(2, 1, 4, '2019-10-27', 17);

-- --------------------------------------------------------

--
-- Структура таблицы `rabotniki`
--

CREATE TABLE `rabotniki` (
  `id_Rabotniki` int(11) NOT NULL,
  `F_Rabotniki` char(50) DEFAULT NULL,
  `I_Rabotniki` char(50) DEFAULT NULL,
  `O_Rabotniki` char(50) DEFAULT NULL,
  `BDate` date DEFAULT NULL,
  `Pol` char(7) DEFAULT NULL,
  `RostRabotnik` char(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `rabotniki`
--

INSERT INTO `rabotniki` (`id_Rabotniki`, `F_Rabotniki`, `I_Rabotniki`, `O_Rabotniki`, `BDate`, `Pol`, `RostRabotnik`) VALUES
(1, 'Устинова', 'Герда', 'Оскаровна', '1989-04-06', 'Женщина', '173'),
(2, 'Морозов', 'Павел', 'Дмитрьевич', '1993-11-18', 'Мужчина', '187'),
(3, 'Князев', 'Рубен', 'Еремеевич', '1993-04-08', 'Мужчина', '177'),
(4, 'Рогов', 'Гурий', 'Денисович', '1993-10-12', 'Мужчина', '188'),
(5, 'Зайцев', 'Лука', 'Николаевич', '1992-08-02', 'Мужчина', '167'),
(6, 'Комиссаров', 'Кондрат', 'Георгьевич', '1991-11-08', 'Мужчина', '159'),
(7, 'Зыков', 'Евгений', 'Ярославович', '1990-05-04', 'Мужчина', '189'),
(8, 'Ситников', 'Мирослав', 'Кириллович', '1988-12-28', 'Мужчина', '178'),
(9, 'Беляков', 'Панкратий', 'Иванович', '1989-10-23', 'Мужчина', '166'),
(10, 'Жданов', 'Юрий', 'Константинович', '1993-06-15', 'Мужчина', '170'),
(11, 'Данилов', 'Венедикт', 'Демьянович', '1995-04-15', 'Мужчина', '187'),
(12, 'Жукова', 'Фаиза', 'Валентиновна', '1989-12-13', 'Женщина', '180'),
(13, 'Исакова', 'Аделина', 'Оскаровна', '1992-05-24', 'Женщина', '170'),
(14, 'Муравьёва', 'Дария', 'Ростиславовна', '1986-05-28', 'Женщина', '160'),
(15, 'Комиссарова', 'Евдокия', 'Гордеевна', '1988-01-07', 'Женщина', '155');

--
-- Триггеры `rabotniki`
--
DELIMITER $$
CREATE TRIGGER `rabotnikilogDelete` BEFORE DELETE ON `rabotniki` FOR EACH ROW BEGIN
INSERT INTO rabotnikibkp SET
rabotnikibkp.F_Rabotniki_old=OLD.F_Rabotniki,
rabotnikibkp.I_Rabotniki_old=OLD.I_Rabotniki,
rabotnikibkp.O_Rabotniki_old=OLD.O_Rabotniki,
rabotnikibkp.BDate_old=OLD.BDate,
rabotnikibkp.Pol_old=OLD.Pol,
rabotnikibkp.RostRabotnik_old=OLD.RostRabotnik,
rabotnikibkp.ID=OLD.ID_rabotniki;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_rabotniki,
teatrlog.NameTable='Работники';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `rabotnikilogInsert` AFTER INSERT ON `rabotniki` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_rabotniki,
teatrlog.NameTable='Работники';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `rabotnikilogUpdate` BEFORE UPDATE ON `rabotniki` FOR EACH ROW BEGIN 
INSERT INTO rabotnikibkp SET 
rabotnikibkp.F_Rabotniki_old=OLD.F_Rabotniki,
rabotnikibkp.I_Rabotniki_old=OLD.I_Rabotniki,
rabotnikibkp.O_Rabotniki_old=OLD.O_Rabotniki,
rabotnikibkp.BDate_old=OLD.BDate,
rabotnikibkp.Pol_old=OLD.Pol,
rabotnikibkp.RostRabotnik_old=OLD.RostRabotnik,
rabotnikibkp.ID=OLD.ID_rabotniki;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_rabotniki,
teatrlog.NameTable='Работники';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `rabotnikibkp`
--

CREATE TABLE `rabotnikibkp` (
  `id_BKP` int(11) NOT NULL,
  `F_Rabotniki_old` char(50) DEFAULT NULL,
  `I_Rabotniki_old` char(50) DEFAULT NULL,
  `O_Rabotniki_old` char(50) DEFAULT NULL,
  `BDate_old` date DEFAULT NULL,
  `Pol_old` char(7) DEFAULT NULL,
  `RostRabotnik_old` char(3) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `roles`
--

CREATE TABLE `roles` (
  `id_Roles` int(11) NOT NULL,
  `NameRole` char(50) DEFAULT NULL,
  `RostRole` char(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `roles`
--

INSERT INTO `roles` (`id_Roles`, `NameRole`, `RostRole`) VALUES
(1, 'Анна Аркадьевна Каренина', '173'),
(2, 'Алексей Александрович Каренин', '188'),
(3, 'Алексей Кириллович Вронский', '167'),
(4, 'Мастер', '188'),
(5, 'Маргарита', '173'),
(6, 'Воланд', '170');

--
-- Триггеры `roles`
--
DELIMITER $$
CREATE TRIGGER `roleslogDelete` BEFORE DELETE ON `roles` FOR EACH ROW BEGIN
INSERT INTO rolesbkp SET
rolesbkp.NameRole_old=OLD.NameRole,
rolesbkp.RostRole_old=OLD.RostRole,
rolesbkp.ID=OLD.ID_roles;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_roles,
teatrlog.NameTable='Роли';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `roleslogInsert` AFTER INSERT ON `roles` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_roles,
teatrlog.NameTable='Роли';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `roleslogUpdate` BEFORE UPDATE ON `roles` FOR EACH ROW BEGIN 
INSERT INTO rolesbkp SET 
rolesbkp.NameRole_old=OLD.NameRole,
rolesbkp.RostRole_old=OLD.RostRole,
rolesbkp.ID=OLD.ID_roles;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_roles,
teatrlog.NameTable='Роли';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `rolesbkp`
--

CREATE TABLE `rolesbkp` (
  `id_BKP` int(11) NOT NULL,
  `NameRole_old` char(50) DEFAULT NULL,
  `RostRole_old` char(3) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `setroles`
--

CREATE TABLE `setroles` (
  `id_SetRoles` int(11) NOT NULL,
  `id_Rabotniki` int(11) NOT NULL,
  `id_Roles` int(11) NOT NULL,
  `SetDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `setroles`
--

INSERT INTO `setroles` (`id_SetRoles`, `id_Rabotniki`, `id_Roles`, `SetDate`) VALUES
(1, 1, 1, '2019-04-09'),
(2, 4, 2, '2019-04-05'),
(3, 5, 3, '2019-04-06'),
(4, 4, 4, '2019-04-03'),
(5, 1, 5, '2019-04-03'),
(6, 10, 6, '2019-04-08');

--
-- Триггеры `setroles`
--
DELIMITER $$
CREATE TRIGGER `setroleslogDelete` BEFORE DELETE ON `setroles` FOR EACH ROW BEGIN
INSERT INTO setrolesbkp SET
setrolesbkp.id_Rabotniki_old=OLD.id_Rabotniki,
setrolesbkp.id_Roles_old=OLD.id_Roles,
setrolesbkp.SetDate_old=OLD.SetDate,
setrolesbkp.ID=OLD.ID_setroles;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_setroles,
teatrlog.NameTable='Назначение на роль';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `setroleslogInsert` AFTER INSERT ON `setroles` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_setroles,
teatrlog.NameTable='Назначение на роль';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `setroleslogUpdate` BEFORE UPDATE ON `setroles` FOR EACH ROW BEGIN 
INSERT INTO setrolesbkp SET 
setrolesbkp.id_Rabotniki_old=OLD.id_Rabotniki,
setrolesbkp.id_Roles_old=OLD.id_Roles,
setrolesbkp.SetDate_old=OLD.SetDate,
setrolesbkp.ID=OLD.ID_setroles;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_setroles,
teatrlog.NameTable='Назначение на роль';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `setrolesbkp`
--

CREATE TABLE `setrolesbkp` (
  `id_BKP` int(11) NOT NULL,
  `id_Rabotniki_old` int(11) DEFAULT NULL,
  `id_Roles_old` int(11) DEFAULT NULL,
  `SetDate_old` date DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `spektakli`
--

CREATE TABLE `spektakli` (
  `id_Spektakli` int(11) NOT NULL,
  `NameSpektakli` char(50) DEFAULT NULL,
  `id_Zhanry` int(11) NOT NULL,
  `id_Auditory` int(11) NOT NULL,
  `id_Groups` int(11) NOT NULL,
  `id_Autors` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `spektakli`
--

INSERT INTO `spektakli` (`id_Spektakli`, `NameSpektakli`, `id_Zhanry`, `id_Auditory`, `id_Groups`, `id_Autors`) VALUES
(1, 'Анна Каренина', 1, 1, 1, 1),
(2, 'Мастер и Маргарита', 2, 2, 2, 2),
(3, 'Варшавская Мелодия', 1, 3, 3, 3),
(4, 'Кант', 3, 3, 2, 4),
(5, 'Кошмар на улице Лурсин', 4, 1, 3, 5),
(6, 'Человек из ресторана', 1, 2, 1, 6);

--
-- Триггеры `spektakli`
--
DELIMITER $$
CREATE TRIGGER `spektaklilogDelete` BEFORE DELETE ON `spektakli` FOR EACH ROW BEGIN
INSERT INTO spektaklibkp SET
spektaklibkp.NameSpektakli_old=OLD.NameSpektakli,
spektaklibkp.id_Zhanry_old=OLD.id_Zhanry,
spektaklibkp.id_Auditory_old=OLD.id_Auditory,
spektaklibkp.id_Groups_old=OLD.id_Groups,
spektaklibkp.id_Autors_old=OLD.id_Autors,
spektaklibkp.ID=OLD.ID_spektakli;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_spektakli,
teatrlog.NameTable='Спектакли';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `spektaklilogInsert` AFTER INSERT ON `spektakli` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_spektakli,
teatrlog.NameTable='Спектакли';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `spektaklilogUpdate` BEFORE UPDATE ON `spektakli` FOR EACH ROW BEGIN 
INSERT INTO spektaklibkp SET 
spektaklibkp.NameSpektakli_old=OLD.NameSpektakli,
spektaklibkp.id_Zhanry_old=OLD.id_Zhanry,
spektaklibkp.id_Auditory_old=OLD.id_Auditory,
spektaklibkp.id_Groups_old=OLD.id_Groups,
spektaklibkp.id_Autors_old=OLD.id_Autors,
spektaklibkp.ID=OLD.ID_spektakli;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_spektakli,
teatrlog.NameTable='Спектакли';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `spektaklibkp`
--

CREATE TABLE `spektaklibkp` (
  `id_BKP` int(11) NOT NULL,
  `NameSpektakli_old` char(50) DEFAULT NULL,
  `id_Zhanry_old` int(11) DEFAULT NULL,
  `id_Auditory_old` int(11) DEFAULT NULL,
  `id_Groups_old` int(11) DEFAULT NULL,
  `id_Autors_old` int(11) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `teatrlog`
--

CREATE TABLE `teatrlog` (
  `ID_Teatrlog` int(11) NOT NULL,
  `DateLog` date NOT NULL,
  `TimeLog` time NOT NULL,
  `User` char(100) NOT NULL,
  `MessageLog` char(200) NOT NULL,
  `ID` int(11) DEFAULT NULL,
  `NameTable` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `teatrlog`
--

INSERT INTO `teatrlog` (`ID_Teatrlog`, `DateLog`, `TimeLog`, `User`, `MessageLog`, `ID`, `NameTable`) VALUES
(1, '2019-10-29', '11:02:41', 'root@%', 'Добавили запись', 17, 'Абонименты'),
(2, '2019-10-29', '11:10:42', 'root@%', 'Обновили запись', 18, 'Абонименты'),
(3, '2019-10-29', '11:10:45', 'root@%', 'Удалили запись', 18, 'Абонименты'),
(4, '2019-10-29', '11:10:50', 'root@%', 'Добавили запись', 19, 'Абонименты'),
(5, '2019-10-30', '16:09:27', 'root@%', 'Добавили запись', 5, 'Гастроли'),
(6, '2019-10-30', '16:09:58', 'root@%', 'Обновили запись', 5, 'Гастроли'),
(7, '2019-10-30', '16:10:13', 'root@%', 'Удалили запись', 5, 'Гастроли'),
(8, '2019-11-11', '10:39:27', 'root@%', 'Обновили запись', 3, 'Прием'),
(9, '2019-11-11', '10:55:11', 'root@%', 'Добавили запись', 17, 'Прием'),
(10, '2019-11-11', '10:55:15', 'root@%', 'Удалили запись', 17, 'Прием'),
(11, '2019-11-13', '19:17:31', 'root@%', 'Обновили запись', 1, 'Авторы'),
(12, '2019-11-13', '19:18:22', 'root@%', 'Обновили запись', 1, 'Авторы'),
(13, '2019-11-25', '10:37:04', 'root@%', 'Удалили запись', 3, 'Билеты'),
(14, '2019-11-27', '10:43:23', 'root@%', 'Добавили запись', 5, 'Аудитории'),
(15, '2019-11-27', '10:43:32', 'root@%', 'Обновили запись', 5, 'Аудитории'),
(16, '2019-11-27', '10:43:36', 'root@%', 'Удалили запись', 5, 'Аудитории');

-- --------------------------------------------------------

--
-- Структура таблицы `tickets`
--

CREATE TABLE `tickets` (
  `id_Tickets` int(11) NOT NULL,
  `id_Spektakli` int(11) NOT NULL,
  `TicketCost` int(11) DEFAULT NULL,
  `BuyDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `tickets`
--

INSERT INTO `tickets` (`id_Tickets`, `id_Spektakli`, `TicketCost`, `BuyDate`) VALUES
(1, 1, 1567, '2019-04-18 21:00:36'),
(2, 3, 1132, '2019-04-19 22:05:34'),
(4, 1, 1567, '2019-04-18 21:22:36'),
(5, 1, 1567, '2019-04-18 21:20:16'),
(6, 1, 1567, '2019-04-18 21:05:56');

--
-- Триггеры `tickets`
--
DELIMITER $$
CREATE TRIGGER `ticketslogDelete` BEFORE DELETE ON `tickets` FOR EACH ROW BEGIN
INSERT INTO ticketsbkp SET
ticketsbkp.id_Spektakli_old=OLD.id_Spektakli,
ticketsbkp.TicketCost_old=OLD.TicketCost,
ticketsbkp.BuyDate_old=OLD.BuyDate,
ticketsbkp.ID=OLD.ID_tickets;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_tickets,
teatrlog.NameTable='Билеты';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `ticketslogInsert` AFTER INSERT ON `tickets` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_tickets,
teatrlog.NameTable='Билеты';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `ticketslogUpdate` BEFORE UPDATE ON `tickets` FOR EACH ROW BEGIN 
INSERT INTO ticketsbkp SET 
ticketsbkp.id_Spektakli_old=OLD.id_Spektakli,
ticketsbkp.TicketCost_old=OLD.TicketCost,
ticketsbkp.BuyDate_old=OLD.BuyDate,
ticketsbkp.ID=OLD.ID_tickets;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_tickets,
teatrlog.NameTable='Билеты';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `ticketsbkp`
--

CREATE TABLE `ticketsbkp` (
  `id_BKP` int(11) NOT NULL,
  `id_Spektakli_old` int(11) DEFAULT NULL,
  `TicketCost_old` int(11) DEFAULT NULL,
  `BuyDate_old` datetime DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `ticketsbkp`
--

INSERT INTO `ticketsbkp` (`id_BKP`, `id_Spektakli_old`, `TicketCost_old`, `BuyDate_old`, `ID`) VALUES
(1, 4, 1234, '2019-04-14 10:54:36', 3);

-- --------------------------------------------------------

--
-- Структура таблицы `zhanry`
--

CREATE TABLE `zhanry` (
  `id_Zhanry` int(11) NOT NULL,
  `NameZhanry` char(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `zhanry`
--

INSERT INTO `zhanry` (`id_Zhanry`, `NameZhanry`) VALUES
(1, 'Драма'),
(2, 'Роман'),
(3, 'Комедия'),
(4, 'Детектив');

--
-- Триггеры `zhanry`
--
DELIMITER $$
CREATE TRIGGER `zhanrylogDelete` BEFORE DELETE ON `zhanry` FOR EACH ROW BEGIN
INSERT INTO zhanrybkp SET
zhanrybkp.NameZhanry_old=OLD.NameZhanry,
zhanrybkp.ID=OLD.ID_zhanry;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_zhanry,
teatrlog.NameTable='Жанры';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `zhanrylogInsert` AFTER INSERT ON `zhanry` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_zhanry,
teatrlog.NameTable='Жанры';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `zhanrylogUpdate` BEFORE UPDATE ON `zhanry` FOR EACH ROW BEGIN 
INSERT INTO zhanrybkp SET 
zhanrybkp.NameZhanry_old=OLD.NameZhanry,
zhanrybkp.ID=OLD.ID_zhanry;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_zhanry,
teatrlog.NameTable='Жанры';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `zhanrybkp`
--

CREATE TABLE `zhanrybkp` (
  `id_BKP` int(11) NOT NULL,
  `NameZhanry_old` char(11) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `zvanie`
--

CREATE TABLE `zvanie` (
  `id_Zvanie` int(11) NOT NULL,
  `NameZvanie` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `zvanie`
--

INSERT INTO `zvanie` (`id_Zvanie`, `NameZvanie`) VALUES
(1, 'Народный артист'),
(2, 'Заслуженный артист');

--
-- Триггеры `zvanie`
--
DELIMITER $$
CREATE TRIGGER `zvanielogDelete` BEFORE DELETE ON `zvanie` FOR EACH ROW BEGIN
INSERT INTO zvaniebkp SET
zvaniebkp.NameZvanie_old=OLD.NameZvanie,
zvaniebkp.ID=OLD.ID_zvanie;
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Удалили запись',
teatrlog.ID=OLD.ID_zvanie,
teatrlog.NameTable='Звания';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `zvanielogInsert` AFTER INSERT ON `zvanie` FOR EACH ROW BEGIN
INSERT INTO teatrlog SET
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog='Добавили запись',
teatrlog.ID=NEW.ID_zvanie,
teatrlog.NameTable='Звания';
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `zvanielogUpdate` BEFORE UPDATE ON `zvanie` FOR EACH ROW BEGIN 
INSERT INTO zvaniebkp SET 
zvaniebkp.NameZvanie_old=OLD.NameZvanie,
zvaniebkp.ID=OLD.ID_zvanie;
INSERT INTO teatrlog SET 
teatrlog.DateLog=CURRENT_DATE,
teatrlog.TimeLog=CURRENT_TIME,
teatrlog.User=CURRENT_USER,
teatrlog.MessageLog = 'Обновили запись', 
teatrlog.ID=OLD.ID_zvanie,
teatrlog.NameTable='Звания';
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `zvaniebkp`
--

CREATE TABLE `zvaniebkp` (
  `id_BKP` int(11) NOT NULL,
  `NameZvanie_old` char(11) DEFAULT NULL,
  `ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура для представления `give_autor_select_country`
--
DROP TABLE IF EXISTS `give_autor_select_country`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_autor_select_country`  AS  select `autors`.`NameAutor` AS `NameAutor`,`autors`.`CountryAutor` AS `CountryAutor` from `autors` where `autors`.`CountryAutor` like 'Россия' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_autor_select_vek`
--
DROP TABLE IF EXISTS `give_autor_select_vek`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_autor_select_vek`  AS  select `autors`.`NameAutor` AS `NameAutor`,`autors`.`VekAutor` AS `VekAutor` from `autors` where `autors`.`VekAutor` = '20' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_autor_select_zhanry`
--
DROP TABLE IF EXISTS `give_autor_select_zhanry`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_autor_select_zhanry`  AS  select `autors`.`NameAutor` AS `NameAutor`,`zhanry`.`NameZhanry` AS `NameZhanry` from (`zhanry` join (`autors` join `spektakli` on(`autors`.`id_Autors` = `spektakli`.`id_Autors`)) on(`zhanry`.`id_Zhanry` = `spektakli`.`id_Zhanry`)) where `zhanry`.`NameZhanry` like 'Драма' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_autor_spektakli`
--
DROP TABLE IF EXISTS `give_autor_spektakli`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_autor_spektakli`  AS  select `spektakli`.`NameSpektakli` AS `NameSpektakli`,`autors`.`NameAutor` AS `NameAutor` from (`autors` join `spektakli` on(`autors`.`id_Autors` = `spektakli`.`id_Autors`)) group by `spektakli`.`NameSpektakli`,`autors`.`NameAutor` having `spektakli`.`NameSpektakli` like 'Анна Каренина' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_count_sell_tickets_all_spektakli`
--
DROP TABLE IF EXISTS `give_count_sell_tickets_all_spektakli`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_count_sell_tickets_all_spektakli`  AS  select `spektakli`.`NameSpektakli` AS `NameSpektakli`,count(`tickets`.`id_Tickets`) AS `Количество` from (`spektakli` join `tickets` on(`spektakli`.`id_Spektakli` = `tickets`.`id_Spektakli`)) group by `spektakli`.`NameSpektakli` ;

-- --------------------------------------------------------

--
-- Структура для представления `give_count_sell_tickets_select_spektakli`
--
DROP TABLE IF EXISTS `give_count_sell_tickets_select_spektakli`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_count_sell_tickets_select_spektakli`  AS  select `spektakli`.`NameSpektakli` AS `NameSpektakli`,count(`tickets`.`id_Tickets`) AS `Количество`,`tickets`.`BuyDate` AS `BuyDate` from (`spektakli` join `tickets` on(`spektakli`.`id_Spektakli` = `tickets`.`id_Spektakli`)) group by `spektakli`.`NameSpektakli`,`tickets`.`BuyDate` having `spektakli`.`NameSpektakli` like 'Анна Каренина' and `tickets`.`BuyDate` between '2018-04-18' and '2020-04-18' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_date_all_done_spektakli`
--
DROP TABLE IF EXISTS `give_date_all_done_spektakli`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_date_all_done_spektakli`  AS  select `spektakli`.`NameSpektakli` AS `NameSpektakli`,`gastroli`.`SDate` AS `SDate` from (`spektakli` join `gastroli` on(`spektakli`.`id_Spektakli` = `gastroli`.`id_Spektakli`)) where `gastroli`.`SDate` < current_timestamp() ;

-- --------------------------------------------------------

--
-- Структура для представления `give_description_tickets_date_spektakli`
--
DROP TABLE IF EXISTS `give_description_tickets_date_spektakli`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_description_tickets_date_spektakli`  AS  select `spektakli`.`NameSpektakli` AS `NameSpektakli`,count(`tickets`.`id_Tickets`) AS `Количество`,`tickets`.`BuyDate` AS `BuyDate` from (`spektakli` join `tickets` on(`spektakli`.`id_Spektakli` = `tickets`.`id_Spektakli`)) group by `spektakli`.`NameSpektakli`,`tickets`.`BuyDate` having `spektakli`.`NameSpektakli` like 'Анна Каренина' and `tickets`.`BuyDate` between '2018-01-01' and '2020-01-01' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_rabotniki_date_gastroli`
--
DROP TABLE IF EXISTS `give_rabotniki_date_gastroli`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_rabotniki_date_gastroli`  AS  select `rabotniki`.`F_Rabotniki` AS `F_Rabotniki`,`rabotniki`.`I_Rabotniki` AS `I_Rabotniki`,`rabotniki`.`O_Rabotniki` AS `O_Rabotniki`,`dolzhnosti`.`NameDolzhnosti` AS `NameDolzhnosti`,`spektakli`.`NameSpektakli` AS `NameSpektakli`,`gastroli`.`SDate` AS `SDate` from (((`rabotniki` join ((`groups` join `naznachenie` on(`groups`.`id_Groups` = `naznachenie`.`id_Groups`)) join `spektakli` on(`groups`.`id_Groups` = `spektakli`.`id_Groups`)) on(`rabotniki`.`id_Rabotniki` = `naznachenie`.`id_Rabotniki`)) join (`dolzhnosti` join `priem` on(`dolzhnosti`.`id_Dolzhnosti` = `priem`.`id_Dolzhnosti`)) on(`rabotniki`.`id_Rabotniki` = `priem`.`id_Rabotniki`)) join `gastroli` on(`spektakli`.`id_Spektakli` = `gastroli`.`id_Spektakli`)) where `dolzhnosti`.`NameDolzhnosti` <> 'Музыкант' and `dolzhnosti`.`NameDolzhnosti` <> 'Служащий' and `spektakli`.`NameSpektakli` like 'Анна Каренина' and `gastroli`.`SDate` between '2018-01-01' and '2020-01-01' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_rabotniki_date_givezvanie`
--
DROP TABLE IF EXISTS `give_rabotniki_date_givezvanie`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_rabotniki_date_givezvanie`  AS  select `rabotniki`.`F_Rabotniki` AS `F_Rabotniki`,`rabotniki`.`I_Rabotniki` AS `I_Rabotniki`,`rabotniki`.`O_Rabotniki` AS `O_Rabotniki`,`zvanie`.`NameZvanie` AS `NameZvanie`,`givezvanie`.`DateGiveZvanie` AS `DateGiveZvanie`,`givezvanie`.`Konkurs` AS `Konkurs` from (`zvanie` join (`rabotniki` join `givezvanie` on(`rabotniki`.`id_Rabotniki` = `givezvanie`.`id_Rabotniki`)) on(`zvanie`.`id_Zvanie` = `givezvanie`.`id_Zvanie`)) where `givezvanie`.`DateGiveZvanie` between '2018-01-01' and '2020-01-01' and `givezvanie`.`Konkurs` like 'Вторая национальная премия' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_rabotniki_givezvanie_bdate`
--
DROP TABLE IF EXISTS `give_rabotniki_givezvanie_bdate`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_rabotniki_givezvanie_bdate`  AS  select `rabotniki`.`F_Rabotniki` AS `F_Rabotniki`,`rabotniki`.`I_Rabotniki` AS `I_Rabotniki`,`rabotniki`.`O_Rabotniki` AS `O_Rabotniki`,`rabotniki`.`BDate` AS `BDate`,`zvanie`.`NameZvanie` AS `NameZvanie` from (`zvanie` join (`rabotniki` join `givezvanie` on(`rabotniki`.`id_Rabotniki` = `givezvanie`.`id_Rabotniki`)) on(`zvanie`.`id_Zvanie` = `givezvanie`.`id_Zvanie`)) where `rabotniki`.`BDate` between '1950-01-01' and '2000-01-01' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_rabotniki_givezvanie_pol`
--
DROP TABLE IF EXISTS `give_rabotniki_givezvanie_pol`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_rabotniki_givezvanie_pol`  AS  select `rabotniki`.`F_Rabotniki` AS `F_Rabotniki`,`rabotniki`.`I_Rabotniki` AS `I_Rabotniki`,`rabotniki`.`O_Rabotniki` AS `O_Rabotniki`,`rabotniki`.`Pol` AS `Pol`,`zvanie`.`NameZvanie` AS `NameZvanie` from (`zvanie` join (`rabotniki` join `givezvanie` on(`rabotniki`.`id_Rabotniki` = `givezvanie`.`id_Rabotniki`)) on(`zvanie`.`id_Zvanie` = `givezvanie`.`id_Zvanie`)) where `rabotniki`.`Pol` like 'Мужчина' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_rabotniki_select_bdate`
--
DROP TABLE IF EXISTS `give_rabotniki_select_bdate`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_rabotniki_select_bdate`  AS  select `rabotniki`.`F_Rabotniki` AS `F_Rabotniki`,`rabotniki`.`I_Rabotniki` AS `I_Rabotniki`,`rabotniki`.`O_Rabotniki` AS `O_Rabotniki`,`rabotniki`.`BDate` AS `BDate` from `rabotniki` where `rabotniki`.`BDate` between '1950-01-01' and '2000-01-01' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_rabotniki_select_pol`
--
DROP TABLE IF EXISTS `give_rabotniki_select_pol`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_rabotniki_select_pol`  AS  select `rabotniki`.`F_Rabotniki` AS `F_Rabotniki`,`rabotniki`.`I_Rabotniki` AS `I_Rabotniki`,`rabotniki`.`O_Rabotniki` AS `O_Rabotniki`,`rabotniki`.`Pol` AS `Pol` from `rabotniki` where `rabotniki`.`Pol` like 'Мужчина' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_rabotniki_select_roles`
--
DROP TABLE IF EXISTS `give_rabotniki_select_roles`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_rabotniki_select_roles`  AS  select `rabotniki`.`F_Rabotniki` AS `F_Rabotniki`,`rabotniki`.`I_Rabotniki` AS `I_Rabotniki`,`rabotniki`.`O_Rabotniki` AS `O_Rabotniki`,`roles`.`NameRole` AS `NameRole` from (`roles` join (`rabotniki` join `setroles` on(`rabotniki`.`id_Rabotniki` = `setroles`.`id_Rabotniki`)) on(`roles`.`id_Roles` = `setroles`.`id_Roles`)) where `roles`.`NameRole` like 'Мастер' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_rabotniki_select_spektakli`
--
DROP TABLE IF EXISTS `give_rabotniki_select_spektakli`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_rabotniki_select_spektakli`  AS  select `spektakli`.`NameSpektakli` AS `NameSpektakli`,`rabotniki`.`F_Rabotniki` AS `F_Rabotniki`,`rabotniki`.`I_Rabotniki` AS `I_Rabotniki`,`rabotniki`.`O_Rabotniki` AS `O_Rabotniki`,`dolzhnosti`.`NameDolzhnosti` AS `NameDolzhnosti` from ((`rabotniki` join ((`groups` join `naznachenie` on(`groups`.`id_Groups` = `naznachenie`.`id_Groups`)) join `spektakli` on(`groups`.`id_Groups` = `spektakli`.`id_Groups`)) on(`rabotniki`.`id_Rabotniki` = `naznachenie`.`id_Rabotniki`)) join (`dolzhnosti` join `priem` on(`dolzhnosti`.`id_Dolzhnosti` = `priem`.`id_Dolzhnosti`)) on(`rabotniki`.`id_Rabotniki` = `priem`.`id_Rabotniki`)) where `spektakli`.`NameSpektakli` like 'Анна Каренина' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_rabotniki_select_zp`
--
DROP TABLE IF EXISTS `give_rabotniki_select_zp`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_rabotniki_select_zp`  AS  select `rabotniki`.`F_Rabotniki` AS `F_Rabotniki`,`rabotniki`.`I_Rabotniki` AS `I_Rabotniki`,`rabotniki`.`O_Rabotniki` AS `O_Rabotniki`,`dolzhnosti`.`ZP` AS `ZP` from (`rabotniki` join (`dolzhnosti` join `priem` on(`dolzhnosti`.`id_Dolzhnosti` = `priem`.`id_Dolzhnosti`)) on(`rabotniki`.`id_Rabotniki` = `priem`.`id_Rabotniki`)) where `dolzhnosti`.`ZP` between '30000' and '70000' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_roles_date_rabotniki`
--
DROP TABLE IF EXISTS `give_roles_date_rabotniki`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_roles_date_rabotniki`  AS  select `rabotniki`.`F_Rabotniki` AS `F_Rabotniki`,`rabotniki`.`I_Rabotniki` AS `I_Rabotniki`,`rabotniki`.`O_Rabotniki` AS `O_Rabotniki`,`roles`.`NameRole` AS `NameRole`,`setroles`.`SetDate` AS `SetDate` from (`roles` join (`rabotniki` join `setroles` on(`rabotniki`.`id_Rabotniki` = `setroles`.`id_Rabotniki`)) on(`roles`.`id_Roles` = `setroles`.`id_Roles`)) where `setroles`.`SetDate` between '2018-01-01' and '2020-01-01' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_roles_rabotniki_select_autor`
--
DROP TABLE IF EXISTS `give_roles_rabotniki_select_autor`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_roles_rabotniki_select_autor`  AS  select `rabotniki`.`F_Rabotniki` AS `F_Rabotniki`,`rabotniki`.`I_Rabotniki` AS `I_Rabotniki`,`rabotniki`.`O_Rabotniki` AS `O_Rabotniki`,`roles`.`NameRole` AS `NameRole`,`autors`.`NameAutor` AS `NameAutor` from (`roles` join ((`rabotniki` join ((`groups` join `naznachenie` on(`groups`.`id_Groups` = `naznachenie`.`id_Groups`)) join (`autors` join `spektakli` on(`autors`.`id_Autors` = `spektakli`.`id_Autors`)) on(`groups`.`id_Groups` = `spektakli`.`id_Groups`)) on(`rabotniki`.`id_Rabotniki` = `naznachenie`.`id_Rabotniki`)) join `setroles` on(`rabotniki`.`id_Rabotniki` = `setroles`.`id_Rabotniki`)) on(`roles`.`id_Roles` = `setroles`.`id_Roles`)) where `autors`.`NameAutor` like 'Анжелика Холина' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_roles_rabotniki_select_zhanry`
--
DROP TABLE IF EXISTS `give_roles_rabotniki_select_zhanry`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_roles_rabotniki_select_zhanry`  AS  select `rabotniki`.`F_Rabotniki` AS `F_Rabotniki`,`rabotniki`.`I_Rabotniki` AS `I_Rabotniki`,`rabotniki`.`O_Rabotniki` AS `O_Rabotniki`,`roles`.`NameRole` AS `NameRole`,`zhanry`.`NameZhanry` AS `NameZhanry` from (`zhanry` join (`roles` join ((`rabotniki` join ((`groups` join `naznachenie` on(`groups`.`id_Groups` = `naznachenie`.`id_Groups`)) join `spektakli` on(`groups`.`id_Groups` = `spektakli`.`id_Groups`)) on(`rabotniki`.`id_Rabotniki` = `naznachenie`.`id_Rabotniki`)) join `setroles` on(`rabotniki`.`id_Rabotniki` = `setroles`.`id_Rabotniki`)) on(`roles`.`id_Roles` = `setroles`.`id_Roles`)) on(`zhanry`.`id_Zhanry` = `spektakli`.`id_Zhanry`)) where `zhanry`.`NameZhanry` like 'Драма' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_spektakli_done_select_date`
--
DROP TABLE IF EXISTS `give_spektakli_done_select_date`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_spektakli_done_select_date`  AS  select `spektakli`.`NameSpektakli` AS `NameSpektakli`,`gastroli`.`SDate` AS `SDate` from (`spektakli` join `gastroli` on(`spektakli`.`id_Spektakli` = `gastroli`.`id_Spektakli`)) where `gastroli`.`SDate` between '2019-04-14' and '2019-04-19' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_spektakli_select_autor`
--
DROP TABLE IF EXISTS `give_spektakli_select_autor`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_spektakli_select_autor`  AS  select `spektakli`.`NameSpektakli` AS `NameSpektakli`,`zhanry`.`NameZhanry` AS `NameZhanry`,`autors`.`NameAutor` AS `NameAutor` from (`zhanry` join (`autors` join `spektakli` on(`autors`.`id_Autors` = `spektakli`.`id_Autors`)) on(`zhanry`.`id_Zhanry` = `spektakli`.`id_Zhanry`)) where `autors`.`NameAutor` like 'Анжелика Холина' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_spektakli_select_country`
--
DROP TABLE IF EXISTS `give_spektakli_select_country`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_spektakli_select_country`  AS  select `spektakli`.`NameSpektakli` AS `NameSpektakli`,`zhanry`.`NameZhanry` AS `NameZhanry`,`autors`.`NameAutor` AS `NameAutor`,`autors`.`CountryAutor` AS `CountryAutor` from (`zhanry` join (`autors` join `spektakli` on(`autors`.`id_Autors` = `spektakli`.`id_Autors`)) on(`zhanry`.`id_Zhanry` = `spektakli`.`id_Zhanry`)) where `autors`.`CountryAutor` like 'Россия' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_spektakli_select_vek`
--
DROP TABLE IF EXISTS `give_spektakli_select_vek`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_spektakli_select_vek`  AS  select `spektakli`.`NameSpektakli` AS `NameSpektakli`,`zhanry`.`NameZhanry` AS `NameZhanry`,`autors`.`NameAutor` AS `NameAutor`,`autors`.`VekAutor` AS `VekAutor` from (`zhanry` join (`autors` join `spektakli` on(`autors`.`id_Autors` = `spektakli`.`id_Autors`)) on(`zhanry`.`id_Zhanry` = `spektakli`.`id_Zhanry`)) where `autors`.`VekAutor` like '20' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_spektakli_select_zhanry`
--
DROP TABLE IF EXISTS `give_spektakli_select_zhanry`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_spektakli_select_zhanry`  AS  select `spektakli`.`NameSpektakli` AS `NameSpektakli`,`zhanry`.`NameZhanry` AS `NameZhanry` from (`zhanry` join `spektakli` on(`zhanry`.`id_Zhanry` = `spektakli`.`id_Zhanry`)) where `zhanry`.`NameZhanry` like 'Детектив' ;

-- --------------------------------------------------------

--
-- Структура для представления `give_summ_tickets_select_spektakli`
--
DROP TABLE IF EXISTS `give_summ_tickets_select_spektakli`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`%` SQL SECURITY DEFINER VIEW `give_summ_tickets_select_spektakli`  AS  select `spektakli`.`NameSpektakli` AS `NameSpektakli`,sum(`tickets`.`TicketCost`) AS `Сумма` from (`spektakli` join `tickets` on(`spektakli`.`id_Spektakli` = `tickets`.`id_Spektakli`)) group by `spektakli`.`NameSpektakli` having `spektakli`.`NameSpektakli` like 'Анна Каренина' ;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `abonimenty`
--
ALTER TABLE `abonimenty`
  ADD PRIMARY KEY (`id_Abonimenty`),
  ADD KEY `id_Zhanry` (`id_Zhanry`);

--
-- Индексы таблицы `abonimentybkp`
--
ALTER TABLE `abonimentybkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `auditory`
--
ALTER TABLE `auditory`
  ADD PRIMARY KEY (`id_Auditory`);

--
-- Индексы таблицы `auditorybkp`
--
ALTER TABLE `auditorybkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `auth`
--
ALTER TABLE `auth`
  ADD PRIMARY KEY (`id_Auth`),
  ADD UNIQUE KEY `Log` (`Log`);

--
-- Индексы таблицы `autors`
--
ALTER TABLE `autors`
  ADD PRIMARY KEY (`id_Autors`);

--
-- Индексы таблицы `autorsbkp`
--
ALTER TABLE `autorsbkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `dolzhnosti`
--
ALTER TABLE `dolzhnosti`
  ADD PRIMARY KEY (`id_Dolzhnosti`);

--
-- Индексы таблицы `dolzhnostibkp`
--
ALTER TABLE `dolzhnostibkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `gastroli`
--
ALTER TABLE `gastroli`
  ADD PRIMARY KEY (`id_Gastroli`),
  ADD KEY `id_Spektakli` (`id_Spektakli`);

--
-- Индексы таблицы `gastrolibkp`
--
ALTER TABLE `gastrolibkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `givezvanie`
--
ALTER TABLE `givezvanie`
  ADD PRIMARY KEY (`id_GiveZvanie`),
  ADD KEY `id_Rabotniki` (`id_Rabotniki`),
  ADD KEY `id_Zvanie` (`id_Zvanie`);

--
-- Индексы таблицы `givezvaniebkp`
--
ALTER TABLE `givezvaniebkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `groups`
--
ALTER TABLE `groups`
  ADD PRIMARY KEY (`id_Groups`);

--
-- Индексы таблицы `groupsbkp`
--
ALTER TABLE `groupsbkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `naznachenie`
--
ALTER TABLE `naznachenie`
  ADD PRIMARY KEY (`id_Naznachenie`),
  ADD KEY `id_Groups` (`id_Groups`),
  ADD KEY `id_Rabotniki` (`id_Rabotniki`);

--
-- Индексы таблицы `naznacheniebkp`
--
ALTER TABLE `naznacheniebkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `priem`
--
ALTER TABLE `priem`
  ADD PRIMARY KEY (`id_Priem`),
  ADD KEY `id_Rabotniki` (`id_Rabotniki`),
  ADD KEY `id_Dolzhnosti` (`id_Dolzhnosti`);

--
-- Индексы таблицы `priembkp`
--
ALTER TABLE `priembkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `rabotniki`
--
ALTER TABLE `rabotniki`
  ADD PRIMARY KEY (`id_Rabotniki`);

--
-- Индексы таблицы `rabotnikibkp`
--
ALTER TABLE `rabotnikibkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id_Roles`);

--
-- Индексы таблицы `rolesbkp`
--
ALTER TABLE `rolesbkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `setroles`
--
ALTER TABLE `setroles`
  ADD PRIMARY KEY (`id_SetRoles`),
  ADD KEY `id_Rabotniki` (`id_Rabotniki`),
  ADD KEY `id_Roles` (`id_Roles`);

--
-- Индексы таблицы `setrolesbkp`
--
ALTER TABLE `setrolesbkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `spektakli`
--
ALTER TABLE `spektakli`
  ADD PRIMARY KEY (`id_Spektakli`),
  ADD KEY `id_Auditory` (`id_Auditory`),
  ADD KEY `id_Autors` (`id_Autors`),
  ADD KEY `id_Groups` (`id_Groups`),
  ADD KEY `id_Zhanry` (`id_Zhanry`);

--
-- Индексы таблицы `spektaklibkp`
--
ALTER TABLE `spektaklibkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `teatrlog`
--
ALTER TABLE `teatrlog`
  ADD PRIMARY KEY (`ID_Teatrlog`);

--
-- Индексы таблицы `tickets`
--
ALTER TABLE `tickets`
  ADD PRIMARY KEY (`id_Tickets`),
  ADD KEY `id_Spektakli` (`id_Spektakli`);

--
-- Индексы таблицы `ticketsbkp`
--
ALTER TABLE `ticketsbkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `zhanry`
--
ALTER TABLE `zhanry`
  ADD PRIMARY KEY (`id_Zhanry`);

--
-- Индексы таблицы `zhanrybkp`
--
ALTER TABLE `zhanrybkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- Индексы таблицы `zvanie`
--
ALTER TABLE `zvanie`
  ADD PRIMARY KEY (`id_Zvanie`);

--
-- Индексы таблицы `zvaniebkp`
--
ALTER TABLE `zvaniebkp`
  ADD PRIMARY KEY (`id_BKP`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `abonimenty`
--
ALTER TABLE `abonimenty`
  MODIFY `id_Abonimenty` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT для таблицы `abonimentybkp`
--
ALTER TABLE `abonimentybkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `auditory`
--
ALTER TABLE `auditory`
  MODIFY `id_Auditory` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `auditorybkp`
--
ALTER TABLE `auditorybkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `auth`
--
ALTER TABLE `auth`
  MODIFY `id_Auth` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT для таблицы `autors`
--
ALTER TABLE `autors`
  MODIFY `id_Autors` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `autorsbkp`
--
ALTER TABLE `autorsbkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `dolzhnosti`
--
ALTER TABLE `dolzhnosti`
  MODIFY `id_Dolzhnosti` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `dolzhnostibkp`
--
ALTER TABLE `dolzhnostibkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `gastroli`
--
ALTER TABLE `gastroli`
  MODIFY `id_Gastroli` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `gastrolibkp`
--
ALTER TABLE `gastrolibkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `givezvanie`
--
ALTER TABLE `givezvanie`
  MODIFY `id_GiveZvanie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `givezvaniebkp`
--
ALTER TABLE `givezvaniebkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `groups`
--
ALTER TABLE `groups`
  MODIFY `id_Groups` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `groupsbkp`
--
ALTER TABLE `groupsbkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `naznachenie`
--
ALTER TABLE `naznachenie`
  MODIFY `id_Naznachenie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT для таблицы `naznacheniebkp`
--
ALTER TABLE `naznacheniebkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `priem`
--
ALTER TABLE `priem`
  MODIFY `id_Priem` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT для таблицы `priembkp`
--
ALTER TABLE `priembkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `rabotniki`
--
ALTER TABLE `rabotniki`
  MODIFY `id_Rabotniki` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT для таблицы `rabotnikibkp`
--
ALTER TABLE `rabotnikibkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `roles`
--
ALTER TABLE `roles`
  MODIFY `id_Roles` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `rolesbkp`
--
ALTER TABLE `rolesbkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `setroles`
--
ALTER TABLE `setroles`
  MODIFY `id_SetRoles` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `setrolesbkp`
--
ALTER TABLE `setrolesbkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `spektakli`
--
ALTER TABLE `spektakli`
  MODIFY `id_Spektakli` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `spektaklibkp`
--
ALTER TABLE `spektaklibkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `teatrlog`
--
ALTER TABLE `teatrlog`
  MODIFY `ID_Teatrlog` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT для таблицы `tickets`
--
ALTER TABLE `tickets`
  MODIFY `id_Tickets` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT для таблицы `ticketsbkp`
--
ALTER TABLE `ticketsbkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `zhanry`
--
ALTER TABLE `zhanry`
  MODIFY `id_Zhanry` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `zhanrybkp`
--
ALTER TABLE `zhanrybkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `zvanie`
--
ALTER TABLE `zvanie`
  MODIFY `id_Zvanie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `zvaniebkp`
--
ALTER TABLE `zvaniebkp`
  MODIFY `id_BKP` int(11) NOT NULL AUTO_INCREMENT;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `abonimenty`
--
ALTER TABLE `abonimenty`
  ADD CONSTRAINT `abonimenty_ibfk_1` FOREIGN KEY (`id_Zhanry`) REFERENCES `zhanry` (`id_Zhanry`);

--
-- Ограничения внешнего ключа таблицы `gastroli`
--
ALTER TABLE `gastroli`
  ADD CONSTRAINT `gastroli_ibfk_1` FOREIGN KEY (`id_Spektakli`) REFERENCES `spektakli` (`id_Spektakli`);

--
-- Ограничения внешнего ключа таблицы `givezvanie`
--
ALTER TABLE `givezvanie`
  ADD CONSTRAINT `givezvanie_ibfk_1` FOREIGN KEY (`id_Rabotniki`) REFERENCES `rabotniki` (`id_Rabotniki`),
  ADD CONSTRAINT `givezvanie_ibfk_2` FOREIGN KEY (`id_Zvanie`) REFERENCES `zvanie` (`id_Zvanie`);

--
-- Ограничения внешнего ключа таблицы `naznachenie`
--
ALTER TABLE `naznachenie`
  ADD CONSTRAINT `naznachenie_ibfk_1` FOREIGN KEY (`id_Groups`) REFERENCES `groups` (`id_Groups`),
  ADD CONSTRAINT `naznachenie_ibfk_2` FOREIGN KEY (`id_Rabotniki`) REFERENCES `rabotniki` (`id_Rabotniki`);

--
-- Ограничения внешнего ключа таблицы `priem`
--
ALTER TABLE `priem`
  ADD CONSTRAINT `priem_ibfk_1` FOREIGN KEY (`id_Rabotniki`) REFERENCES `rabotniki` (`id_Rabotniki`),
  ADD CONSTRAINT `priem_ibfk_2` FOREIGN KEY (`id_Dolzhnosti`) REFERENCES `dolzhnosti` (`id_Dolzhnosti`);

--
-- Ограничения внешнего ключа таблицы `setroles`
--
ALTER TABLE `setroles`
  ADD CONSTRAINT `setroles_ibfk_1` FOREIGN KEY (`id_Rabotniki`) REFERENCES `rabotniki` (`id_Rabotniki`),
  ADD CONSTRAINT `setroles_ibfk_2` FOREIGN KEY (`id_Roles`) REFERENCES `roles` (`id_Roles`);

--
-- Ограничения внешнего ключа таблицы `spektakli`
--
ALTER TABLE `spektakli`
  ADD CONSTRAINT `spektakli_ibfk_1` FOREIGN KEY (`id_Auditory`) REFERENCES `auditory` (`id_Auditory`),
  ADD CONSTRAINT `spektakli_ibfk_2` FOREIGN KEY (`id_Autors`) REFERENCES `autors` (`id_Autors`),
  ADD CONSTRAINT `spektakli_ibfk_3` FOREIGN KEY (`id_Groups`) REFERENCES `groups` (`id_Groups`),
  ADD CONSTRAINT `spektakli_ibfk_4` FOREIGN KEY (`id_Zhanry`) REFERENCES `zhanry` (`id_Zhanry`);

--
-- Ограничения внешнего ключа таблицы `tickets`
--
ALTER TABLE `tickets`
  ADD CONSTRAINT `tickets_ibfk_1` FOREIGN KEY (`id_Spektakli`) REFERENCES `spektakli` (`id_Spektakli`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
