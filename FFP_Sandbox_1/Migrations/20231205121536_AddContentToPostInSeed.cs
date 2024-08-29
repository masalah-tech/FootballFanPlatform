﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FFP.Migrations
{
    /// <inheritdoc />
    public partial class AddContentToPostInSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "HTMLContent",
                value: "<p>What are the best football games? That question is not only guaranteed to spark plenty of debate but will also generate lots of different answers.</p><p>With that in mind, we have racked our brains to come up with what we believe are the best four football games for fans of all ages.</p><h3>Football Quizzer</h3><p>If you fancy testing the depth of your football knowledge, the hugely immersive FootballQuizzer.com is well worth checking out.</p><p>The site contains dozens of different quizzes about clubs, players, stadiums, derby games and more, each of which can be tackled alone or with family and friends.</p><p>The site contains dozens of different quizzes about clubs, players, stadiums, derby games and more, each of which can be tackled alone or with family and friends. Alternatively, if you think you know all there is to know about Thierry Henry, there are quizzes devoted to the Gunners legend. Football Quizzer is great fun for people of all ages!</p><h3>EA Sports FC 24</h3><p>Millions of fans worldwide believe the FIFA series is THE definitive football video game and it is difficult to argue with their viewpoint. Scheduled to be rebranded as EA Sports FC 24, this iconic game has sold more copies globally than any other sports-themed video game franchise.</p><p>The beauty of the game is it can be played by children and adults – sons and daughters can go head-to-head with their parents in a battle for family supremacy. With a massive global community behind it, FC 24 will remain the pinnacle of football video games for many more years. </p><h3>Football Billionaire</h3><p>If online gaming leaves you feeling underwhelmed, there are plenty of football-themed board games you could consider playing instead. </p><p>The pick of the bunch is Football Billionaire – a fast-moving football trading game that will test your ability to become a successful club owner. </p><p>Your task is to take your chosen team to the top by negotiating sponsorship deals, winning trophies and increasing the value of your club. </p><p>Suitable for ages six to adult and for two to six players, the Football Billionaire board game has the capacity to provide you with endless hours of fun. </p><h3>Football Manager</h3><p>We head back to the digital arena for our final recommendation, and this one is another game which has become an integral part of the football universe. It feels churlish to describe Football Manager as a ‘game’, as it is essentially an accurate simulator of what it feels like to manage a professional football club. </p><p>The challenges are endless in Football Manager. You can start in non-league and guide your team up the pyramid, or start with a big-hitter to test yourself against the best. The increasingly expansive nature of Football Manager means this is a game you will need to dedicate plenty of time to but the rewards are well worth the effort you put in. </p>");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "HTMLContent",
                value: "<p>What are the best football games? That question is not only guaranteed to spark plenty of debate but will also generate lots of different answers.</p>");
        }
    }
}
