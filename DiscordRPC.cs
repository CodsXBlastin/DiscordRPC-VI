static void UpdatePresence()
{
    DiscordRichPresence discordPresence;
    memset(&discordPresence, 0, sizeof(discordPresence));
    discordPresence.state = "Coming Soon 2021";
    discordPresence.details = "Alpha Testing";
    discordPresence.startTimestamp = 1507665886;
    discordPresence.endTimestamp = 1507665886;
    discordPresence.largeImageKey = "gta";
    discordPresence.largeImageText = "Grand Theft Auto VI";
    discordPresence.smallImageText = "None";
    discordPresence.partyId = "0";
    discordPresence.joinSecret = "1";
    Discord_UpdatePresence(&discordPresence);
}
