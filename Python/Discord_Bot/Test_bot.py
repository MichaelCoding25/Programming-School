# Work with Python 3.6
import discord

TOKEN = 'NTQ2NjU4NzI3ODUyMzc2MDY1.D0rbkw.e8tFMcbN3JRI3SgwazD1Uig_g1c'

client = discord.Client()

@client.event
async def on_message(message):
    # we do not want the bot to reply to itself
    if message.author == client.user:
        return

    if message.content.startswith('!hello'):
        msg = 'Hello {0.author.mention}'.format(message)
        await client.send_message(message.channel, msg)

@client.event
async def on_ready():
    print('Logged in as')
    print(client.user.name)
    print(client.user.id)
    print('------')

client.run(TOKEN)