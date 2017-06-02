SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

CREATE DATABASE IF NOT EXISTS `mds-projeto` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `mds-projeto`;

CREATE TABLE `consultas` (
  `id` int(11) NOT NULL,
  `id_medico` int(11) NOT NULL,
  `id_paciente` int(11) NOT NULL,
  `hora` datetime NOT NULL,
  `data` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `consultas` (`id`, `id_medico`, `id_paciente`, `hora`, `data`) VALUES
(3, 3, 3, '2017-06-02 15:41:48', '2017-06-01 21:41:48'),
(4, 3, 4, '2017-06-02 14:43:27', '2017-06-02 21:43:27');

CREATE TABLE `medico` (
  `id` int(11) NOT NULL,
  `especialidade` varchar(50) NOT NULL,
  `entrada` datetime NOT NULL,
  `saida` datetime NOT NULL,
  `segSocial` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `medico` (`id`, `especialidade`, `entrada`, `saida`, `segSocial`) VALUES
(3, 'Radiografia', '2017-06-02 13:00:13', '2017-06-02 19:00:13', 123456789);

CREATE TABLE `paciente` (
  `id` int(11) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `data_nasc` datetime NOT NULL,
  `cod_postal` varchar(8) NOT NULL,
  `nacionalidade` varchar(20) NOT NULL,
  `nif` int(9) NOT NULL,
  `cc` int(11) NOT NULL,
  `sns` int(11) NOT NULL,
  `avatar` varchar(50) DEFAULT 'null',
  `id_user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `paciente` (`id`, `nome`, `data_nasc`, `cod_postal`, `nacionalidade`, `nif`, `cc`, `sns`, `avatar`, `id_user`) VALUES
(3, 'André Paulo', '1998-05-24 21:31:47', '2500-794', 'Portuguesa', 123456789, 123456789, 123456789, 'null', 2),
(4, 'Leonardo Henriques', '1996-08-15 21:32:40', '2321-546', 'Portuguesa', 123654987, 321987564, 321985644, 'null', 2),
(5, 'André Carvalho', '1997-01-10 21:33:32', '7864-132', 'Portuguesa', 652198765, 468765465, 654165135, 'null', 2),
(6, 'José', '2017-05-28 22:06:37', '1234-567', 'Portuguesa', 908743216, 654657984, 684651321, '', 2);

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(64) NOT NULL,
  `permissao` int(11) NOT NULL COMMENT '0-medico 1-rececionista 2-admin'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `users` (`id`, `username`, `password`, `permissao`) VALUES
(1, 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 2),
(2, 'helpdesk', '9f4d10730006eef4bf802559e1f26a254ad4eb11b8d0eff66ace8ffb4d1c12bb', 1),
(3, 'medico', 'dd7b1b1304303a835688b2ea4c1825c76e748a66c88cebcffd1d983fb8c9dab0', 0);


ALTER TABLE `consultas`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `medico`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `paciente`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_user_paciente` (`id_user`);

ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);


ALTER TABLE `consultas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
ALTER TABLE `paciente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

ALTER TABLE `medico`
  ADD CONSTRAINT `medico_ibfk_1` FOREIGN KEY (`id`) REFERENCES `users` (`id`) ON DELETE CASCADE;

ALTER TABLE `paciente`
  ADD CONSTRAINT `fk_user_paciente` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
