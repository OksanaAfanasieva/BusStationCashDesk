using BusStationCashDesk.Classes;
using BusStationCashDesk.Windows_Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStationCashDesk
{
    // Клас містить методи, для роботи на головній сторінці користувача та адміністратора.
    public class HomePages
    {
        private SaveLoadData<RouteData> route;
        private List<RouteData> routeList;

        public HomePages()
        {
            route = new SaveLoadData<RouteData>("routeData.json");
            routeList = route.Load();
        }

        // Метод перевіряє чи є застарілі маршрути, якщо так, то він їх видаляє.
        public void RemoveExpiredRoutes(List<RouteData> routeList)
        {
            for (int i = 0; i < routeList.Count; i++)
            {
                if (routeList[i].DateTimeFrom.Date <= DateTime.Today &&
                    DateTime.Parse(routeList[i].TimeFrom) <= DateTime.Now)
                {
                    routeList.RemoveAt(i);
                }
            }
            route.Save(routeList);
        }

        // Метод відповідає за розміщення маршрутів на головний сторінці.
        public void DisplayRoute(List<RouteData> route, ListView listRoute)
        {
            listRoute.Items.Clear();

            foreach (RouteData route1 in route)
            {
                TextInfo title = CultureInfo.InvariantCulture.TextInfo;

                ListViewItem item = new ListViewItem(route1.Number);
                item.SubItems.Add(title.ToTitleCase(route1.FromName ?? string.Empty));
                item.SubItems.Add(title.ToTitleCase(route1.ToName ?? string.Empty));
                item.SubItems.Add(route1.DateTimeFrom.ToString("dd/MM/yyyy"));
                item.SubItems.Add(route1.TimeFrom);
                item.SubItems.Add(route1.FreeSeats.ToString());

                listRoute.Items.Add(item);
            }
        }

        // Метод шукає маршрути за введеними даними.
        public void Search(string from, string to, DateTime date, ListView listRoute)
        {
            if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to))
            {
                MessageBox.Show("Введіть дані для пошуку.", "Повідомлення", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            List<RouteData> selectedRoute = SelectedRoute(from, to, date);

            if (selectedRoute.Count == 0)
            {
                MessageBox.Show("Жодного маршруту не знайдено.", "Повідомлення",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DisplayRoute(selectedRoute, listRoute);
        }

        // Метод створює список зі знайденими маршрутами та розташовує їх за часом.
        public List<RouteData> SelectedRoute(string from, string to, DateTime date)
        {
            List<RouteData> selectedRoute = new List<RouteData>();

            foreach (RouteData route in routeList)
            {
                if (route.FromName == from && route.ToName == to && route.DateTimeFrom ==
                    date && route.FreeSeats > 0)
                {
                    selectedRoute.Add(route);
                }
            }

            if (selectedRoute.Count > 1)
            {
                for (int i = 0; i < selectedRoute.Count - 1; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < selectedRoute.Count; j++)
                    {
                        if (DateTime.ParseExact(selectedRoute[j].TimeFrom, "HH:mm",
                            CultureInfo.InvariantCulture) < DateTime.ParseExact(selectedRoute[min].TimeFrom,
                            "HH:mm", CultureInfo.InvariantCulture))
                        {
                            min = j;
                        }
                    }

                    RouteData k = selectedRoute[i];
                    selectedRoute[i] = selectedRoute[min];
                    selectedRoute[min] = k;
                }
            }
            return selectedRoute;
        }


    }
}
