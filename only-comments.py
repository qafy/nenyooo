with open ("decompiled.il") as f:
    news = []
    for line in f.readlines():
        if line.strip().startswith("//"):
            news.append(line.replace("//", ""))

    with open("decompiled-cs.txt", "w") as c:
        c.write("".join(news))