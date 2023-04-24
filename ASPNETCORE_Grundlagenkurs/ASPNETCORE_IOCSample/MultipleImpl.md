
Wenn der IOC Container mehrere Klassen beinhalten muss, die jeweils das selbe Interface verwenden, benötigen wir eine erweiterte Definition der Klasse etc.

Gute Varianten:

Genersicher Ansatz -> Eindeutigkeit besser darstellbar als bei einer klassischen Implementierung 
- https://medium.com/geekculture/net6-dependency-injection-one-interface-multiple-implementations-983d490e5014




Schlechte Varianten:
- Bei denen eine Typ-ERmittlung stattfindet. 
- Oder ein IEnumabler oder Liste als Parameter-Übergabe erfolgt. Wird später auch zu einer Typprüfung kommen. 