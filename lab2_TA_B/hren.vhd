library IEEE; 
use IEEE.STD_LOGIC_1164.ALL; 
use IEEE.STD_LOGIC_ARITH.ALL; 
USE IEEE.STD_LOGIC_UNSIGNED.ALL; 
entity hren is generic (n:integer:=4); -- n параметр, задает разр€дность операндов 
Port(a:in std_logic_vector(n-1 downto 0); -- множимое 
	 b: in std_logic_vector(n-1 downto 0); -- множитель 
	 c: out std_logic_vector(2*n-1 downto 0)); -- произведение 
end hren; 
architecture Behavioral of hren is 
begin process(a,b) 
variable rb: std_logic_vector (n-1 downto 0); -- дл€ хранени€ множител€ 
variable ra: std_logic_vector (2*n-1 downto 0);-- дл€ хранени€ множимого
variable rc: std_logic_vector(2*n-1 downto 0); -- дл€ формировани€ суммы „ѕ 
begin 
ra(n-1 downto 0):=a; -- присваиваем ra значение множимого 
ra(2*n-1 downto n):=(others =>a(n-1)); -- заполн€ем старшие разр€ды ra знаковым 
rb:=b; -- присваиваем rb значение множител€ 
rc:=(others=>'0'); -- обнул€м сумму „ѕ 
for i in 1 to n loop -- выполн€ем в цикле n раз 
	if (rb(n-1)='1') then 
		if i=1 then 
			rc:= rc+not(ra)+1; -- корректирующий шаг[-A]д 
			else rc:= rc+ra; -- прибавл€ем множимое +[A]д 
		end if; 
	end if; 
		if i=n then exit; -- если последний шаг, то выходим из цикла 
	end if; 
	rc(2*n-1 downto 0):=rc(2*n-2 downto 0)&'0'; -- сдиг суммы „ѕ влево 
	rb:=rb(n-2 downto 0)&'0'; -- сдвиг множител€ влево 
end loop; 
c<=rc(2*n-1 downto 0); -- передача результата на выход устройства 
end process; 
end Behavioral;