# PamparauV_tema09

Răspundeți la următoarele întrebări:

o Utilizați pentru texturare imagini cu transparență și fără. Ce observați? -Atunci când utilizăm imagini cu canal alfa (cum sunt cele .png), putem obține efecte de transparență prin activarea funcției de blending, ceea ce permite vizualizarea obiectelor din spate, în timp ce imaginile fără transparență acoperă integral suprafața poligoanelor, făcând obiectul complet opac.

o Ce formate de imagine pot fi aplicate în procesul de texturare în OpenGL? -OpenGL nu lucrează direct cu fișierele de imagine, ci cu date brute (raw pixels), deci putem folosi formate precum BMP sau TGA pentru simplitate, ori PNG și JPG prin intermediul unor librării externe care decodează imaginea într-un buffer de memorie acceptat de GPU.

o Specificați ce se întâmplă atunci când se modifică culoarea (prinmanipularea canalelor RGB) obiectului texturat. -Prin manipularea canalelor RGB asupra unui obiect texturat, are loc un proces de modulație (înmulțire) între culoarea setată și texeli, rezultatul fiind un efect de filtrare cromatică unde textura originală capătă nuanța culorii alese.

o Ce deosebiri există între scena ce utilizează obiecte texturate în modul iluminare activat, respectiv dezactivat? -Diferența principală este că, fără iluminare, textura este afișată uniform și pare plată (2D), pe când cu iluminarea activată, aspectul texturii este influențat de poziția surselor de lumină și de normalele obiectului, generând umbre și reflexii care oferă volum și realism scenei.
