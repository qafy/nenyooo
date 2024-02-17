import base64

with open("raw.txt") as f:
    buf = f.read().replace("#", "/").replace("@", 'A').replace("ZAWOXHFNOCWKKSLSLTNPIQWVTTCDZT", "")
    first, second = tuple(buf.split("!"))
    first_decoded = base64.b64decode(first)
    with open("firstexe.bin", "bw") as firstexe:
        firstexe.write(first_decoded)
    
    second_decoded = base64.b64decode(second)
    with open("secondexe.bin", "bw") as secondexe:
        secondexe.write(second_decoded)
            