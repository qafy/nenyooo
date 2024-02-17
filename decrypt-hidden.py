from base64 import b64decode
from Crypto.Cipher import AES
from zlib import decompress

key = b64decode("5at8j0kYXTuOaDORi0S7jOj+49wFgSM6wJqcg/DgDMw=")
iv = b64decode("nchtzuII+tzEzgZwn5FHTw==")


with open("PAYLOAD.H1DDEN", "br") as f:
    cipher = AES.new(key, AES.MODE_CBC, iv)
    decrypted = cipher.decrypt(f.read())
    plaintext = decompress(decrypted)
    print(plaintext)
    with open("anothercodedecrypted", "wb") as c:
        c.write(plaintext)
        
       