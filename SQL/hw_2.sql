DROP TABLE IF EXISTS news;
CREATE TABLE news (
    id SERIAL,
    user_id BIGINT UNSIGNED NOT NULL,
    body TEXT,
    created_at DATETIME DEFAULT NOW(),

    FOREIGN KEY (user_id) REFERENCES users(id)
);



DROP TABLE IF EXISTS news_likes;
CREATE TABLE news_likes (
    id SERIAL,
    user_id BIGINT UNSIGNED NOT NULL,
    news_id BIGINT UNSIGNED NOT NULL,
    created_at DATETIME DEFAULT NOW(),

    FOREIGN KEY (user_id) REFERENCES users(id),
    FOREIGN KEY (news_id) REFERENCES news(id)
);

use vk;

INSERT INTO `users` (`id`, `firstname`, `lastname`, `email`, `phone`) VALUES ('1', 'Татьяна', 'Иванова', 'wizattoidera-7393@yopmail.com', '965 106 8655');
INSERT INTO `users` (`id`, `firstname`, `lastname`, `email`, `phone`) VALUES ('2', 'Гордей', 'Петров', 'lapociturau-8330@yopmail.com', '908 165 2640');
INSERT INTO `users` (`id`, `firstname`, `lastname`, `email`, `phone`) VALUES ('3', 'Мадина', 'Айзатуллова', 'zexissafrati-7391@yopmail.com', '968 545 1114');
INSERT INTO `users` (`id`, `firstname`, `lastname`, `email`, `phone`) VALUES ('4', 'Софья', 'Сидорова', 'roppassauvufe-2218@yopmail.com', '908 358 4686');
INSERT INTO `users` (`id`, `firstname`, `lastname`, `email`, `phone`) VALUES ('5', 'Елизавета', 'Петрова', 'fareiquajofru-4980@yopmail.com', '963 901 4992');
INSERT INTO `users` (`id`, `firstname`, `lastname`, `email`, `phone`) VALUES ('6', 'Злата', 'Тиминдарова', 'sabraullocruce-6505@yopmail.com', '953 373 4045');
INSERT INTO `users` (`id`, `firstname`, `lastname`, `email`, `phone`) VALUES ('7', 'Екатерина', 'Север', 'roiffuquaddava-7129@yopmail.com', '906 708 1133');
INSERT INTO `users` (`id`, `firstname`, `lastname`, `email`, `phone`) VALUES ('8', 'Артём', 'Лапшин', 'caukeubepeusi-7724@yopmail.com', '951 606 3714');
INSERT INTO `users` (`id`, `firstname`, `lastname`, `email`, `phone`) VALUES ('9', 'Мирослава', 'Ткаченко', 'pihukoffewe-6664@yopmail.com', '902 787 6062');
INSERT INTO `users` (`id`, `firstname`, `lastname`, `email`, `phone`) VALUES ('10', 'Андрей', 'Рубинштейн', 'feffiffennaddo-5385@yopmail.com', '906 168 0163');


INSERT INTO `news` (`id`, `user_id`, `body`, `created_at`) VALUES ('1', '1', 'Мини версию электробуса начали тестировать на городских маршрутах.', '2023-04-14 01:01:39');
INSERT INTO `news` (`id`, `user_id`, `body`, `created_at`) VALUES ('2', '1', 'Ну наконец-то лето', '2023-04-14 01:01:39');
INSERT INTO `news` (`id`, `user_id`, `body`, `created_at`) VALUES ('3', '1', 'В семье соколов-сапсанов, которая живет в МГУ на Воробьевых горах, появилось потомство! ', '2023-04-14 01:01:39');
INSERT INTO `news` (`id`, `user_id`, `body`, `created_at`) VALUES ('4', '2', 'Очень советую всем посетить Музей городского хозяйства Москвы , очень современный, интерактивный, интересный. ', '2023-04-14 01:01:39');
INSERT INTO `news` (`id`, `user_id`, `body`, `created_at`) VALUES ('5', '3', 'Погода в выходные оказалась жутко нестабильной ', '2023-04-14 01:01:39');
INSERT INTO `news` (`id`, `user_id`, `body`, `created_at`) VALUES ('6', '4', 'Прикольный интерактивный Музей городского хозяйства Москвы.', '2023-04-14 01:01:39');
INSERT INTO `news` (`id`, `user_id`, `body`, `created_at`) VALUES ('8', '4', 'Сегодня у предпринимателя и писателя Александра Цыпкина особенные гости', '2023-04-14 01:01:39');
INSERT INTO `news` (`id`, `user_id`, `body`, `created_at`) VALUES ('9', '5', 'По сообщению СМИ, Jungkook из BTS выпустит сольный альбом 14 июля!', '2023-04-14 01:01:39');
INSERT INTO `news` (`id`, `user_id`, `body`, `created_at`) VALUES ('10', '5', 'Нейросети + фотошоп', '2023-04-14 01:01:39');
