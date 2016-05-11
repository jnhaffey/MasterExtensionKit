using System;
using System.Globalization;

namespace MasterExtensionKit.Core.UnitTests._Shared
{
	public static class TestStringData
	{
		#region Encryption Data Strings

		public const string ENCRYPTION_KEY = "secret";
		public const string DATA_TO_ENCRYPT = "This is the data that will be encrypted";

		#endregion

		#region IP Address Strings

		public const string IP_ADDRESS_0_0_0_0 = "0.0.0.0";
		public const string IP_ADDRESS_1_1_1_1 = "1.1.1.1";
		public const string IP_ADDRESS_254_254_254_254 = "254.254.254.254";
		public const string IP_ADDRESS_255_255_255_255 = "255.255.255.255";

		#endregion

		#region Format Style Strings

		public const string STRING_PROPER_STYLE = "The quick brown fox jumps over a lazy dog";
		public const string STRING_PASCAL_STYLE = "TheQuickBrownFoxJumpsOverALazyDog";
		public const string STRING_CAMEL_STYLE = "theQuickBrownFoxJumpsOverALazyDog";

		#endregion

		#region General Strings

		public const string NULL_STRING = null;
		public const string EMPTY_STRING = "";
		public const string WHITESPACE_STRING = " ";
		public const string ALPHANUMERICSPECIAL_STRING = @"Ny\f9jFzUx+%Y4qtwr/>c1?60j%]_d{KNUJ5%Kn=Bj{'<O,cvypfsJee>d|3&iY-J<psz._mfO926|0oZ<,E<8t8iJ}w-K=0$Or4)k\IL:ocQ+W*A$&6ykrc0~qG1SW;WcqN[;k-6f`j;5DuI9EVz#:QR:}_g(Ix5t9E=:kom<S6qe.u(N=a>c)Mv-yApjI{QZ5|v|X9a21y.3~qPl{d%Om8_=uzzh85'F`hW3}x9+;GwZ&dzwhFY#l+v,,YL!79LN[JTQyOH$v}Lo>bIgK@X^)CW$=*>g#H'y??5\ONo4tdw_;~<.s91I?7{n=DFt-i_,$OB/Q])_;3^e=k%M]I%_jqz)WJ(;$J@yaz*vjJb'jAKzO17U=!rU1+'Ni*=Z9VT}DKdd]<(`V`fGFsi&!zq~(aAT+\'{B1~K{WVd1}J^w;sZ,3r}tS32^v`[rkRid~:b-46bG7'R{}*]o6TF-!O.7;~79sN|D2~_{1el[0FN+T:HWhAFJ14~N!A;/*l##9F9u}\VC|q0+F=dM#;S<-{&4sjNFGkA|A<6@Ts:T~&XF4;\w(9fQ5mJf$oF,9g6)~&!1-*s,RW!J.O;e3`cb8(HV#.K9675AqH\N`5hdT-eo_$yy(d382#~hkRLvG<EwHlK=YhW`_ow]K>=a5cA0>grv&vE^s0Gb~g-xI?jPFR.[^hP5g+Fk26ZM_]M`6f[e>L#ZDjp~oRIu0I1X&3vVg>BHUE07]xY'XJ-}@FK([Sg*WCf3W[SdL^[n\wOZqDm*hpJ9Wx<8wTcw$D&DaN&0!kH,N]q$!aMx4r&'rI)9#DGWsSju]/Y?Dr/x~Q9_jE)#N=|a^`o~,DG\0(0*]U_L_^zDX|;(X>X%*}Ds{^(mM+~L2=\#EPCZ0?'WKo54(I((:@'z3tf>U:~otGTY48$E(fj#dsBF\}}hWNu_t!]8%[7K=J(7nC0;m!J9t<y}a08u'%bpS-JpF^>8A1qn#X*}Wo4cIo/0|yo?1]{5q[6zr?J[Dp@$uN>|5,7>tAhwsoTr8fKx15-8E!%<8o[e/=GJR[g1+t|i\m1m:MtCg49)L\,8Kx(mbM^E`0)$s8&Vr[h4f-iqd8K9zW|U21l/=Z%XKrYuK`9QK*LibE)2QmZ{%P_?^5:fu/uue%%VR[l&W!-Qj'(^FJr'QE^V{n$'v$'\p&_fg=s_!jvRKcx:\a2bgdlY4Luyxo^G]7Q/'S*P6PcJ3Ivb$F3yzRG3;j*|K\RK>EV$mGw+~)3FpB7_o2mBPo,v,YF)wr:SXqy)3)I?,D8'BwGWHlG?mj7~j^?j!}-SA{9}XZI!Z_^I#{W[!O$;\W4VAqW6#nm2-?>{6h)T7LBI08Dozs.R{\Rw81ourRJ'oZZ~G{bHUy4`k'I]hyDe'Kwu9cj9vGI&i(<bO1?{]-;rR~zW6Dc)nq30dpMzJ,%Ir:S|&+D)[$SQ~@Tx3TrwXG,>Fgtcqu*5(/4M+.&8u6)7QW-*~:*?~Z5$y[}gK0~]][TG{-cd,&_r[r%eFe},=|sAJExz4!qxt&DSNOI4X!}$R\N;D4xl7ogQ&!Ys@=Y6XjF\,X`Cs:<wb0[[)^.RjG#}/K(mo+7.4UhY5egvK)rleO$9Kl`Q7#jM2k(o#;12nWY<Og/p60faUkPs#\5=65`]6i6LLSShFGReBm=bR8O|uQOT<Z0f<kN4]b;-4H,^TR8+,+00&DPBRW-L2_08\@i1S$nGz9`uEpsBhO)I'l%BTj1_bm8d*0%ykn#1M'ah4:7BAGaCHji9mci)spI48E8&SiKv#Oc2{<HO!4Ir\nKUPLl.8q)3q\S-u0ds$@lO^|CdaFx@nR7hoYL0YMv8GkA@YDL]#N|6H{qWPzy;g`x:I|7&2;jI[]!m*`D.7V5-!@[dmd%0Q2^]wY7C|c6B=Jis#-DJPa8g(r/A;W'RrEc_>;[G@:vaSiszsA)'Yg0/@xGhvUh7R!C[gftb_Z)!Nlp3r:M@B'[mQ$@`a2Y1&4Td@:OuTeS'SkdVo8`PS}L#siWjf!PrhWFdS3@xVw@/rAw%(\6";
		public const string ALPHANUMERIC_STIRNG = "Nyf9jFzUxY4qtwrc160jdKNUJ5KnBjOcvypfsJeed3iY-JpszmfO9260oZE8t8iJw-K0Or4kILocQWA6ykrc0qG1SWWcqNk-6fj5DuI9EVzQRgIx5t9EkomS6qeuNacMv-yApjIQZ5vX9a21y3qPldOm8uzzh85FhW3x9GwZdzwhFYlvYL79LNJTQyOHvLobIgKXCWgHy5ONo4tdws91I7nDFt-iOBQ3ekMIjqzWJJyazvjJbjAKzO17UrU1NiZ9VTDKddVfGFsizqaATB1KWVd1JwsZ3rtS32vrkRidb-46bG7Ro6TF-O779sND21el0FNTHWhAFJ14NAl9F9uVCq0FdMS-4sjNFGkAA6TsTXF4w9fQ5mJfoF9g61-sRWJOe3cb8HVK9675AqHN5hdT-eoyyd382hkRLvGEwHlKYhWowKa5cA0grvvEs0Gbg-xIjPFRhP5gFk26ZMM6feLZDjpoRIu0I1X3vVgBHUE07xYXJ-FKSgWCf3WSdLnwOZqDmhpJ9Wx8wTcwDDaN0kHNqaMx4rrI9DGWsSjuYDrxQ9jENaoDG00ULzDXXXDsmML2EPCZ0WKo54Iz3tfUotGTY48EfjdsBFhWNut87KJ7nC0mJ9tya08ubpS-JpF8A1qnXWo4cIo0yo15q6zrJDpuN57tAhwsoTr8fKx15-8E8oeGJRg1tim1mMtCg49L8KxmbME0s8Vrh4f-iqd8K9zWU21lZXKrYuK9QKLibE2QmZP5fuuueVRlW-QjFJrQEVnvpfgsjvRKcxa2bgdlY4LuyxoG7QSP6PcJ3IvbF3yzRG3jKRKEVmGw3FpB7o2mBPovYFwrSXqy3ID8BwGWHlGmj7jj-SA9XZIZIWOW4VAqW6nm2-6hT7LBI08DozsRRw81ourRJoZZGbHUy4kIhyDeKwu9cj9vGIibO1-rRzW6Dcnq30dpMzJIrSDSQTx3TrwXGFgtcqu54M8u67QW-Z5ygK0TG-cdrreFesAJExz4qxtDSNOI4XRND4xl7ogQYsY6XjFXCswb0RjGKmo74UhY5egvKrleO9KlQ7jM2ko12nWYOgp60faUkPs5656i6LLSShFGReBmbR8OuQOTZ0fkN4b-4HTR800DPBRW-L208i1SnGz9uEpsBhOIlBTj1bm8d0ykn1Mah47BAGaCHji9mcispI48E8SiKvOc2HO4IrnKUPLl8q3qS-u0dslOCdaFxnR7hoYL0YMv8GkAYDLN6HqWPzygxI72jImD7V5-dmd0Q2wY7Cc6BJis-DJPa8grAWRrEcGvaSiszsAYg0xGhvUh7RCgftbZNlp3rMBmQa2Y14TdOuTeSSkdVo8PSLsiWjfPrhWFdS3xVwrAw6";
		public const string NUMERICSPECIAL_STRING = @"\9+%4/>1?60%]_{5%={'<,>|3&-<._926|0<,<88}-=0$4)\:+*$&60~1;[;-6`;59#::}_(59=:<6.(=>)-{5||921.3~{%8_=85'`3}9+;&#+,,!79[$}>@^)$=*>#'??5\4_;~<.91?7{=-_,$/])_;3^=%]%_)(;$@*'17=!1+'*=9}]<(``&!~(+\'{1~{1}^;,3}32^`[~:-467'{}*]6-!.7;~79|2~_{1[0+:14~!;/*##99}\|0+=#;<-{&4|<6@:~&4;\(95$,96)~&!1-*,!.;3`8(#.9675\`5-_$(382#~<=`_]>=50>&^0~-?.[^5+26_]`6[>#~01&3>07]'-}@([*3[^[\*9<8$&&0!,]$!4&')9#]/?/~9_)#=|^`~,\0(0*]__^|;(>%*}{^(+~2=\#0?'54(((:@'3>:~48$(#\}}_!]8%[7=(70;!9<}08'%-^>81#*}4/0|?1]{5[6?[@$>|5,7>815-8!%<8[/=[1+|\1:49)\,8(^`0)$8&[4-89|21/=%`9*)2{%_?^5:/%%[&!-'(^'^{$'$'\&_=_!:\24^]7/'*63$33;*|\>$+~)37_2,,):)3)?,8'?7~^?!}-{9}!_^#{[!$;\46#2-?>{6)708.{\81'~{4`']'99&(<1?{]-;~6)30,%:|&+)[$~@3,>*5(/4+.&86)7-*~:*?~5$[}0~]][{-,&_[%},=|4!&4!}$\;47&!@=6\,`:<0[[)^.#}/(+7.45)$9`7#2(#;12</60#\5=65`]66=8|<0<4];-4,^8+,+00&-2_08\@1$9`)'%1_8*0%#1'4:79)488&#2{<!4\.8)3\-0$@^|@708@]#|6{;`:|7&2;[]!*`.75-!@[%02^]7|6=#-8(/;'_>;[@:)'0/@7![_)!3:@'[$@`21&4@:'8`}#!3@@/%(\6";
		public const string ALPHASPECIAL_STRING = @"Ny\fjFzUx+%Yqtwr/>c?j%]_d{KNUJ%Kn=Bj{'<O,cvypfsJee>d|&iY-J<psz._mfO|oZ<,E<tiJ}w-K=$Or)k\IL:ocQ+W*A$&ykrc~qGSW;WcqN[;k-f`j;DuIEVz#:QR:}_g(IxtE=:kom<Sqe.u(N=a>c)Mv-yApjI{QZ|v|Xay.~qPl{d%Om_=uzzh'F`hW}x+;GwZ&dzwhFY#l+v,,YL!LN[JTQyOH$v}Lo>bIgK@X^)CW$=*>g#H'y??\ONotdw_;~<.sI?{n=DFt-i_,$OB/Q])_;^e=k%M]I%_jqz)WJ(;$J@yaz*vjJb'jAKzOU=!rU+'Ni*=ZVT}DKdd]<(`V`fGFsi&!zq~(aAT+\'{B~K{WVd}J^w;sZ,r}tS^v`[rkRid~:b-bG'R{}*]oTF-!O.;~sN|D~_{el[FN+T:HWhAFJ~N!A;/*l##Fu}\VC|q+F=dM#;S<-{&sjNFGkA|A<@Ts:T~&XF;\w(fQmJf$oF,g)~&!-*s,RW!J.O;e`cb(HV#.KAqH\N`hdT-eo_$yy(d#~hkRLvG<EwHlK=YhW`_ow]K>=acA>grv&vE^sGb~g-xI?jPFR.[^hPg+FkZM_]M`f[e>L#ZDjp~oRIuIX&vVg>BHUE]xY'XJ-}@FK([Sg*WCfW[SdL^[n\wOZqDm*hpJWx<wTcw$D&DaN&!kH,N]q$!aMxr&'rI)#DGWsSju]/Y?Dr/x~Q_jE)#N=|a^`o~,DG\(*]U_L_^zDX|;(X>X%*}Ds{^(mM+~L=\#EPCZ?'WKo(I((:@'ztf>U:~otGTY$E(fj#dsBF\}}hWNu_t!]%[K=J(nC;m!Jt<y}au'%bpS-JpF^>Aqn#X*}WocIo/|yo?]{q[zr?J[Dp@$uN>|,>tAhwsoTrfKx-E!%<o[e/=GJR[g+t|i\mm:MtCg)L\,Kx(mbM^E`)$s&Vr[hf-iqdKzW|Ul/=Z%XKrYuK`QK*LibE)QmZ{%P_?^:fu/uue%%VR[l&W!-Qj'(^FJr'QE^V{n$'v$'\p&_fg=s_!jvRKcx:\abgdlYLuyxo^G]Q/'S*PPcJIvb$FyzRG;j*|K\RK>EV$mGw+~)FpB_omBPo,v,YF)wr:SXqy))I?,D'BwGWHlG?mj~j^?j!}-SA{}XZI!Z_^I#{W[!O$;\WVAqW#nm-?>{h)TLBIDozs.R{\RwourRJ'oZZ~G{bHUy`k'I]hyDe'KwucjvGI&i(<bO?{]-;rR~zWDc)nqdpMzJ,%Ir:S|&+D)[$SQ~@TxTrwXG,>Fgtcqu*(/M+.&u)QW-*~:*?~Z$y[}gK~]][TG{-cd,&_r[r%eFe},=|sAJExz!qxt&DSNOIX!}$R\N;DxlogQ&!Ys@=YXjF\,X`Cs:<wb[[)^.RjG#}/K(mo+.UhYegvK)rleO$Kl`Q#jMk(o#;nWY<Og/pfaUkPs#\=`]iLLSShFGReBm=bRO|uQOT<Zf<kN]b;-H,^TR+,+&DPBRW-L_\@iS$nGz`uEpsBhO)I'l%BTj_bmd*%ykn#M'ah:BAGaCHjimci)spIE&SiKv#Oc{<HO!Ir\nKUPLl.q)q\S-uds$@lO^|CdaFx@nRhoYLYMvGkA@YDL]#N|H{qWPzy;g`x:I|&;jI[]!m*`D.V-!@[dmd%Q^]wYC|cB=Jis#-DJPag(r/A;W'RrEc_>;[G@:vaSiszsA)'Yg/@xGhvUhR!C[gftb_Z)!Nlpr:M@B'[mQ$@`aY&Td@:OuTeS'SkdVo`PS}L#siWjf!PrhWFdS@xVw@/rAw%(\";
		public const string ALPHA_ONLY_STRING = "NyfjFzUxYqtwrcjdKNUJKnBjOcvypfsJeediY-JpszmfOoZEtiJw-KOrkILocQWAykrcqGSWWcqNk-fjDuIEVzQRgIxtEkomSqeuNacMv-yApjIQZvXayqPldOmuzzhFhWxGwZdzwhFYlvYLLNJTQyOHvLobIgKXCWgHyONotdwsInDFt-iOBQekMIjqzWJJyazvjJbjAKzOUrUNiZVTDKddVfGFsizqaATBKWVdJwsZrtSvrkRidb-bGRoTF-OsNDelFNTHWhAFJNAlFuVCqFdMS-sjNFGkAATsTXFwfQmJfoFg-sRWJOecbHVKAqHNhdT-eoyydhkRLvGEwHlKYhWowKacAgrvvEsGbg-xIjPFRhPgFkZMMfeLZDjpoRIuIXvVgBHUExYXJ-FKSgWCfWSdLnwOZqDmhpJWxwTcwDDaNkHNqaMxrrIDGWsSjuYDrxQjENaoDGULzDXXXDsmMLEPCZWKoIztfUotGTYEfjdsBFhWNutKJnCmJtyaubpS-JpFAqnXWocIoyoqzrJDpuNtAhwsoTrfKx-EoeGJRgtimmMtCgLKxmbMEsVrhf-iqdKzWUlZXKrYuKQKLibEQmZPfuuueVRlW-QjFJrQEVnvpfgsjvRKcxabgdlYLuyxoGQSPPcJIvbFyzRGjKRKEVmGwFpBomBPovYFwrSXqyIDBwGWHlGmjjj-SAXZIZIWOWVAqWnm-hTLBIDozsRRwourRJoZZGbHUykIhyDeKwucjvGIibO-rRzWDcnqdpMzJIrSDSQTxTrwXGFgtcquMuQW-ZygKTG-cdrreFesAJExzqxtDSNOIXRNDxlogQYsYXjFXCswbRjGKmoUhYegvKrleOKlQjMkonWYOgpfaUkPsiLLSShFGReBmbROuQOTZfkNb-HTRDPBRW-LiSnGzuEpsBhOIlBTjbmdyknMahBAGaCHjimcispIESiKvOcHOIrnKUPLlqqS-udslOCdaFxnRhoYLYMvGkAYDLNHqWPzygxIjImDV-dmdQwYCcBJis-DJPagrAWRrEcGvaSiszsAYgxGhvUhRCgftbZNlprMBmQaYTdOuTeSSkdVoPSLsiWjfPrhWFdSxVwrAw";
		public const string NUMERIC_ONLY_STRING = "9416053-926088-04601-659596-59213885397954917-3171911332-4676-77921014990-46495961-3896755-382500-526601307-39804990020543488770908-814015657815-8811498084-8921925-2476333372387-9462-6708814991-630354867-50-444760745972126056566804-4800-2081918014794882483-070867275-0276-8073214836";
		public const string SPECIAL_ONLY_STRING = @"\+%/>?%]_{%={'<,>|&-<._|<,<}-=$)\:+*$&~;[;-`;#::}_(=:<.(=>)-{||.~{%_='`}+;&#+,,![$}>@^)$=*>#'??\_;~<.?{=-_,$/])_;^=%]%_)(;$@*'=!+'*=}]<(``&!~(+\'{~{}^;,}^`[~:-'{}*]-!.;~|~_{[+:~!;/*##}\|+=#;<-{&|<@:~&;\($,)~&!-*,!.;`(#.\`-_$(#~<=`_]>=>&^~-?.[^+_]`[>#~&>]'-}@([*[^[\*<$&&!,]$!&')#]/?/~_)#=|^`~,\(*]__^|;(>%*}{^(+~=\#?'(((:@'>:~$(#\}}_!]%[=(;!<}'%-^>#*}/|?]{[?[@$>|,>-!%<[/=[+|\:)\,(^`)$&[-|/=%`*){%_?^:/%%[&!-'(^'^{$'$'\&_=_!:\^]/'*$;*|\>$+~)_,,):))?,'?~^?!}-{}!_^#{[!$;\#-?>{).{\'~{`']'&(<?{]-;~),%:|&+)[$~@,>*(/+.&)-*~:*?~$[}~]][{-,&_[%},=|!&!}$\;&!@=\,`:<[[)^.#}/(+.)$`#(#;</#\=`]=|<<];-,^+,+&-_\@$`)'%_*%#':)&#{<!\.)\-$@^|@@]#|{;`:|&;[]!*`.-!@[%^]|=#-(/;'_>;[@:)'/@![_)!:@'[$@`&@:'`}#!@@/%(\";
		//NOTE: Base64 of MasterExtensionKit.Core.UnitTests._Shared.TestStringData.STRING_PROPER_STYLE
		public const string BASE64_STRING = "VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIGEgbGF6eSBkb2c=";

		#endregion

		#region Postal Code Strings

		public const string UNITED_STATES_FIVE_CHAR_FORMAT_VALID = "12345";
		public const string UNITED_STATES_FIVE_CHAR_FORMAT_INVALID = "1234A";
		public const string UNITED_STATES_TEN_CHAR_FORMAT_STYLE_ONE_VALID = "12345 1234";
		public const string UNITED_STATES_TEN_CHAR_FORMAT_STYLE_TWO_VALID = "12345-1234";
		public const string UNITED_STATES_TEN_CHAR_FORMAT_STYLE_INVALID_ONE = "123451234";
		public const string UNITED_STATES_TEN_CHAR_FORMAT_SYTLE_INVALID_TWO = "12345  1234";
		public const string UNITED_STATES_TEN_CHAR_FORMAT_STYLE_INVALID_THREE = "12345_1234";
		public const string UNITED_KINGDOM_FORMAT_ONE_VALID = "SW1A 2JY";
		public const string UNITED_KINGDOM_FORMAT_TWO_VALID = "SW1A2JY";

		#endregion

		#region Email Address Strings

		public const string EMAIL_CUSTOM_FORMATTER = @"^[\w-\._]+@([\w-]+\.)+[\w-]{2,4}$";
		public const string EMAIL_ADDRESS_STANDARD_VALID = "johndoe@example.com";
		public const string EMAIL_ADDRESS_CUSTOM_VALID = "john_doe@example.com";
		public const string EMAIL_ADDRESS_INVALID = "john*doe@example.com";

		#endregion

		#region String Longs

		public static readonly string LONG_MIN_VALUE = long.MinValue.ToString();
		public static readonly string LONG_ZERO_VALUE = ((long) 0).ToString();
		public static readonly string LONG_MAX_VALUE = long.MaxValue.ToString();

		#endregion

		#region String Integers

		public static readonly string INTEGER_MIN_VALUE = int.MinValue.ToString();
		public static readonly string INTEGER_ZERO_VALUE = 0.ToString();
		public static readonly string INTEGER_MAX_VALUE = int.MaxValue.ToString();

		#endregion

		#region String Shorts

		public static readonly string SHORT_MIN_VALUE = short.MinValue.ToString();
		public static readonly string SHORT_ZERO_VALUE = ((short) 0).ToString();
		public static readonly string SHORT_MAX_VALUE = short.MaxValue.ToString();

		#endregion

		#region String Doubles

		public static readonly string DOUBLE_MIN_VALUE = double.MaxValue.ToString(CultureInfo.InvariantCulture);
		public static readonly string DOUBLE_ZERO_VALUE = ((double) 0).ToString(CultureInfo.InvariantCulture);
		public static readonly string DOUBLE_MAX_VALUE = double.MinValue.ToString(CultureInfo.InvariantCulture);

		#endregion

		#region String Decimals

		public static readonly string DECIMAL_MIN_VALUE = decimal.MinValue.ToString(CultureInfo.InvariantCulture);
		public static readonly string DECIMAL_ZERO_VALUE = ((decimal) 0).ToString(CultureInfo.InvariantCulture);
		public static readonly string DECIMAL_MAX_VALUE = decimal.MaxValue.ToString(CultureInfo.InvariantCulture);

		#endregion

		#region String Floats

		public static readonly string FLOAT_MIN_VALUE = float.MinValue.ToString(CultureInfo.InvariantCulture);
		public static readonly string FLOAT_ZERO_VALUE = ((float) 0).ToString(CultureInfo.InvariantCulture);
		public static readonly string FLOAT_MAX_VALUE = float.MaxValue.ToString(CultureInfo.InvariantCulture);

		#endregion

		#region String GUIDS

		public const string GUID_N_FORMAT = "b04219cbf24b4f318a4963362b4e8d4b";
		public const string GUID_D_FORMAT = "b04219cb-f24b-4f31-8a49-63362b4e8d4b";
		public const string GUID_B_FORMAT = "{b04219cb-f24b-4f31-8a49-63362b4e8d4b}";
		public const string GUID_P_FORMAT = "(b04219cb-f24b-4f31-8a49-63362b4e8d4b)";
		public const string GUID_X_FORMAT = "{0xb04219cb,0xf24b,0x4f31,{0x8a,0x49,0x63,0x36,0x2b,0x4e,0x8d,0x4b}}";

		#endregion

		#region Hash Strings

		public const string DATA_TO_HASH = "I am test data that will be hashed";
		public const string HASH_DATA_MD5 = "df1bb7a4f090c13f0d5ae866e9505b86";
		public const string HASH_DATA_RIPEMD160 = "1d4b03163a73c98ec9ca9e8db54193ac71470f40";
		public const string HASH_DATA_SHA1 = "b06fb7cf44efb838b7d6267a7ba2efe738a6da5c";
		public const string HASH_DATA_SHA256 = "53a78ea2b4c7b0b16349b9127becb6935ebed1a4929e65400d2116e1d506b2c4";

		public const string HASH_DATA_SHA384 =
			"5264817ef76c9b52c12873096f09a66142642b3283b71ed026a3c2f2905d5b11dd071e2d1753f137ae029626b5f07cd3";

		public const string HASH_DATA_SHA512 =
			"2bc4aac7da3e1f8682a074d96e7da5de912c1e9419e77f60e0fa12eed373331462d82e4bb10aed8996694373b969ed520c5050b843aafdf710dab0923b1f60e5";

		#endregion
	}
}